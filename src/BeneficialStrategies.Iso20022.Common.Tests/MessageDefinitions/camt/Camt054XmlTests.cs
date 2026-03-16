// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: PENDING EXTERNAL VALIDATION
// TODO: Validate against https://www.iso20022.org/sites/default/files/schemas/camt.054.001.11.xsd
//
// This file exercises deserialization of a camt.054.001.11 debit/credit notification.
// The sample covers one notification with two credit entries, each with EntryDetails >
// TransactionDetails containing references and remittance information.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using EntryStatusCode = BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice.Code;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="BankToCustomerDebitCreditNotificationV11"/>
/// (camt.054.001.11 — Bank to Customer Debit Credit Notification).
///
/// The sample file covers BNP Paribas sending two intraday credit notifications to
/// GlobalSupply S.A.S. for two incoming SEPA credit transfers. Both entries are CRDT/BOOK
/// and carry transaction details with distinct UETRs.
/// </summary>
public class Camt054XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.054.001.11_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "BNPAFRPP/240315/CAM054/00001";
    private const string ExpectedMsgRcptName = "GlobalSupply S.A.S.";
    private const string ExpectedNtfctnId = "BNPAFRPP-GLOBALSUPPLY-NTFN-20240315-001";
    private const string ExpectedEntry1Uetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";
    private const string ExpectedEntry2Uetr = "b1c2d3e4-f5a6-7890-abcd-ef1234567890";

    // ── Helper ─────────────────────────────────────────────────────────────────

    private static XDocument LoadEmbeddedXml()
    {
        var asm = Assembly.GetExecutingAssembly();
        using var stream =
            asm.GetManifestResourceStream(ResourceName)
            ?? throw new InvalidOperationException(
                $"Embedded resource '{ResourceName}' not found. "
                    + $"Available: {string.Join(", ", asm.GetManifestResourceNames())}"
            );
        return XDocument.Load(stream);
    }

    // ── Tests ──────────────────────────────────────────────────────────────────

    /// <summary>
    /// Verifies that the group header deserializes correctly, including
    /// MessageIdentification and the MessageRecipient name.
    /// </summary>
    [Fact]
    public void Deserialize_GroupHeader_HasCorrectMsgId()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.NotNull(result.GroupHeader.MessageRecipient);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient.Name);
    }

    /// <summary>
    /// Verifies that the notification carries two <c>&lt;Ntry&gt;</c> elements and
    /// that both are credit entries (CdtDbtInd == CRDT).
    /// </summary>
    [Fact]
    public void Deserialize_Notification_TwoEntries_BothCredit()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        var ntfctn = result.Notification;
        Assert.Equal(ExpectedNtfctnId, ntfctn.Identification);
        Assert.Equal(2, ntfctn.Entry.Count);
        Assert.Equal(CreditDebitCode.Credit, ntfctn.Entry[0].CreditDebitIndicator);
        Assert.Equal(CreditDebitCode.Credit, ntfctn.Entry[1].CreditDebitIndicator);
    }

    /// <summary>
    /// Verifies that the first entry's transaction details carry the expected UETR
    /// (the reference UETR shared across the test scenario for invoice INV-2024-847).
    /// </summary>
    [Fact]
    public void Deserialize_FirstEntry_HasCorrectUetr()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        var entry1 = result.Notification.Entry[0];
        Assert.NotEmpty(entry1.EntryDetails);

        var txDtls = entry1.EntryDetails[0].TransactionDetails[0];
        Assert.NotNull(txDtls.References);
        Assert.Equal(ExpectedEntry1Uetr, txDtls.References.UETR);
    }

    /// <summary>
    /// Verifies that the second entry carries a different UETR from the first,
    /// confirming that transaction-level references are independent per entry.
    /// </summary>
    [Fact]
    public void Deserialize_SecondEntry_HasDifferentUetr()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        var entry2 = result.Notification.Entry[1];
        Assert.NotEmpty(entry2.EntryDetails);

        var txDtls = entry2.EntryDetails[0].TransactionDetails[0];
        Assert.NotNull(txDtls.References);
        Assert.Equal(ExpectedEntry2Uetr, txDtls.References.UETR);
        Assert.NotEqual(ExpectedEntry1Uetr, txDtls.References.UETR);
    }

    /// <summary>
    /// Verifies that the first entry's remittance information contains two
    /// unstructured lines (the <see cref="RemittanceInformation21.Unstructured"/>
    /// collection must have Count == 2).
    /// </summary>
    [Fact]
    public void Deserialize_FirstEntry_RemittanceHasTwoLines()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        var txDtls = result.Notification.Entry[0].EntryDetails[0].TransactionDetails[0];
        Assert.NotNull(txDtls.RemittanceInformation);
        Assert.Equal(2, txDtls.RemittanceInformation.Unstructured.Count);
    }

    /// <summary>
    /// Deserialize → serialize → deserialize. Both entries and their sub-collections
    /// (transaction details, remittance) must survive the round-trip with identical values.
    /// </summary>
    [Fact]
    public void RoundTrip_TwoEntries_BothSurvive()
    {
        var original = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerDebitCreditNotificationV11>(xml);

        // Group header
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient?.Name);

        // Entries
        Assert.Equal(2, result.Notification.Entry.Count);
        Assert.Equal(CreditDebitCode.Credit, result.Notification.Entry[0].CreditDebitIndicator);
        Assert.Equal(CreditDebitCode.Credit, result.Notification.Entry[1].CreditDebitIndicator);
        Assert.Equal(47_250.00m, result.Notification.Entry[0].Amount.Amount);
        Assert.Equal(12_500.00m, result.Notification.Entry[1].Amount.Amount);

        // UETRs survive round-trip
        var tx1 = result.Notification.Entry[0].EntryDetails[0].TransactionDetails[0];
        Assert.Equal(ExpectedEntry1Uetr, tx1.References?.UETR);

        var tx2 = result.Notification.Entry[1].EntryDetails[0].TransactionDetails[0];
        Assert.Equal(ExpectedEntry2Uetr, tx2.References?.UETR);

        // Remittance lines survive
        Assert.Equal(2, tx1.RemittanceInformation?.Unstructured.Count);
    }
}
