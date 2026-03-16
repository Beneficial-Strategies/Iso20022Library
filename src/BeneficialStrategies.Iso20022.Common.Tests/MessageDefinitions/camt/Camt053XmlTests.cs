// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: PENDING EXTERNAL VALIDATION
// TODO: Validate against https://www.iso20022.org/sites/default/files/schemas/camt.053.001.11.xsd
//
// This file exercises deserialization of a camt.053.001.11 end-of-day account statement.
// The sample covers one statement with two balances (OPBD + CLBD) and two entries (CRDT + DBIT),
// each with EntryDetails > TransactionDetails containing references and remittance information.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BalTypeCode = BeneficialStrategies.Iso20022.Choices.BalanceType10Choice.Code;
using EntryStatusCode = BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice.Code;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Embedded-resource XML tests for <see cref="BankToCustomerStatementV11"/>
/// (camt.053.001.11 — Bank to Customer Statement).
///
/// The sample file covers an end-of-day statement for Acme Manufacturing GmbH
/// at Deutsche Bank, with two balances (opening/closing booked) and two entries
/// (one incoming SEPA credit, one outgoing SEPA debit), each with transaction
/// details and remittance information.
/// </summary>
public class Camt053XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.camt.053.001.11_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "DEUTDEFF/240315/CAM053/00001";
    private const string ExpectedMsgRcptName = "Acme Manufacturing GmbH";
    private const string ExpectedStmtId = "DEUTDEFF-ACME-STMT-20240315-001";
    private const decimal ExpectedOpeningBalance = 905_500.00m;
    private const decimal ExpectedClosingBalance = 952_750.00m;
    private const string ExpectedUetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";

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
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.NotNull(result.GroupHeader.MessageRecipient);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient.Name);
    }

    /// <summary>
    /// Verifies that the statement carries two <c>&lt;Bal&gt;</c> elements with the
    /// expected opening (OPBD, EUR 905,500) and closing (CLBD, EUR 952,750) booked
    /// balances.
    /// </summary>
    [Fact]
    public void Deserialize_Statement_TwoBalances_OpeningAndClosing()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        var stmt = result.Statement;
        Assert.Equal(ExpectedStmtId, stmt.Identification);
        Assert.Equal(2, stmt.Balance.Count);

        // Balance 1 — Opening Booked
        var bal1 = stmt.Balance[0];
        var balCode1 = Assert.IsType<BalTypeCode>(bal1.Type.CodeOrProprietary);
        Assert.Equal(ExternalBalanceType1Code.OpeningBooked, balCode1.Value);
        Assert.Equal("EUR", bal1.Amount.Currency);
        Assert.Equal(ExpectedOpeningBalance, bal1.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal1.CreditDebitIndicator);

        // Balance 2 — Closing Booked
        var bal2 = stmt.Balance[1];
        var balCode2 = Assert.IsType<BalTypeCode>(bal2.Type.CodeOrProprietary);
        Assert.Equal(ExternalBalanceType1Code.ClosingBooked, balCode2.Value);
        Assert.Equal("EUR", bal2.Amount.Currency);
        Assert.Equal(ExpectedClosingBalance, bal2.Amount.Amount);
        Assert.Equal(CreditDebitCode.Credit, bal2.CreditDebitIndicator);
    }

    /// <summary>
    /// Verifies that the statement carries two <c>&lt;Ntry&gt;</c> elements: the first
    /// is a credit (incoming payment) and the second is a debit (outgoing payment).
    /// </summary>
    [Fact]
    public void Deserialize_Statement_TwoEntries_CreditAndDebit()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        var stmt = result.Statement;
        Assert.Equal(2, stmt.Entry.Count);

        var entry1 = stmt.Entry[0];
        Assert.Equal(CreditDebitCode.Credit, entry1.CreditDebitIndicator);
        Assert.Equal("EUR", entry1.Amount.Currency);
        Assert.Equal(47_250.00m, entry1.Amount.Amount);
        Assert.IsType<EntryStatusCode>(entry1.Status);

        var entry2 = stmt.Entry[1];
        Assert.Equal(CreditDebitCode.Debit, entry2.CreditDebitIndicator);
        Assert.Equal("EUR", entry2.Amount.Currency);
        Assert.Equal(47_250.00m, entry2.Amount.Amount);
    }

    /// <summary>
    /// Verifies that the credit entry's transaction details (nested inside
    /// <c>&lt;NtryDtls&gt;/&lt;TxDtls&gt;</c>) carry the expected UETR.
    /// </summary>
    [Fact]
    public void Deserialize_CreditEntry_HasTransactionDetails()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        var creditEntry = result.Statement.Entry[0];
        Assert.NotEmpty(creditEntry.EntryDetails);

        var entryDetails = creditEntry.EntryDetails[0];
        Assert.NotEmpty(entryDetails.TransactionDetails);

        var txDtls = entryDetails.TransactionDetails[0];
        Assert.NotNull(txDtls.References);
        Assert.Equal(ExpectedUetr, txDtls.References.UETR);
        Assert.Equal("ACME/INV-2024-847/PAY001", txDtls.References.EndToEndIdentification);
    }

    /// <summary>
    /// Verifies that the credit entry's remittance information contains two
    /// unstructured lines (the <see cref="RemittanceInformation21.Unstructured"/>
    /// collection must have Count == 2).
    /// </summary>
    [Fact]
    public void Deserialize_CreditEntry_RemittanceHasTwoLines()
    {
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        var txDtls = result.Statement.Entry[0].EntryDetails[0].TransactionDetails[0];
        Assert.NotNull(txDtls.RemittanceInformation);
        Assert.Equal(2, txDtls.RemittanceInformation.Unstructured.Count);
    }

    /// <summary>
    /// Deserialize → serialize → deserialize. Both balances and both entries
    /// (with their sub-collections) must survive the round-trip with identical values.
    /// </summary>
    [Fact]
    public void RoundTrip_TwoBalancesAndEntries_AllSurvive()
    {
        var original = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(xml);

        // Group header
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(ExpectedMsgRcptName, result.GroupHeader.MessageRecipient?.Name);

        // Balances
        Assert.Equal(2, result.Statement.Balance.Count);
        Assert.Equal(ExpectedOpeningBalance, result.Statement.Balance[0].Amount.Amount);
        Assert.Equal(ExpectedClosingBalance, result.Statement.Balance[1].Amount.Amount);

        // Entries
        Assert.Equal(2, result.Statement.Entry.Count);
        Assert.Equal(CreditDebitCode.Credit, result.Statement.Entry[0].CreditDebitIndicator);
        Assert.Equal(CreditDebitCode.Debit, result.Statement.Entry[1].CreditDebitIndicator);

        // Transaction details — UETR survives round-trip
        var txDtls = result.Statement.Entry[0].EntryDetails[0].TransactionDetails[0];
        Assert.Equal(ExpectedUetr, txDtls.References?.UETR);

        // Remittance lines survive
        Assert.Equal(2, txDtls.RemittanceInformation?.Unstructured.Count);
    }
}
