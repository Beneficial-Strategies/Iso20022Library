// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: PENDING EXTERNAL VALIDATION
// TODO: The Amount element serialization uses library-internal format for InstructedAmount;
//       validate against the ISO XSD once the library adopts the canonical Ccy-attribute
//       simpleContent pattern for choice-type amount variants.
//
// Scenario: Acme Manufacturing GmbH instructs Deutsche Bank to pay GlobalSupply S.A.S.
//           for two invoices in a single PmtInf block with two CdtTrfTxInf items.
//           Tests verify correct deserialization of the scalar PaymentInformation and the
//           ValueList<CreditTransferTransaction54> CreditTransferTransactionInformation.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;
using IbanChoice = BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN;

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Embedded-resource XML tests for <see cref="CustomerCreditTransferInitiationV11"/>
/// (pain.001.001.11 — Customer Credit Transfer Initiation).
///
/// The sample file contains a single <c>&lt;PmtInf&gt;</c> with two
/// <c>&lt;CdtTrfTxInf&gt;</c> elements, verifying that:
/// <list type="bullet">
///   <item><see cref="CustomerCreditTransferInitiationV11.PaymentInformation"/> is a
///     scalar (not a collection).</item>
///   <item><see cref="PaymentInstruction40.CreditTransferTransactionInformation"/> is a
///     <c>ValueList&lt;CreditTransferTransaction54&gt;</c> that populates both items.</item>
/// </list>
/// </summary>
public class Pain001XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pain.001.001.11_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "ACME/240315/PAI001/00001";
    private const string ExpectedPmtInfId = "ACME/240315/PMTINF/001";
    private const string ExpectedDebtorName = "Acme Manufacturing GmbH";
    private const string ExpectedDebtorIban = "DE89370400440532013000";
    private const string ExpectedUetr1 = "97ed4827-7b6f-4491-a06f-b548d5a7512d";
    private const string ExpectedEndToEndId1 = "ACME/INV-2024-847/PAY001";
    private const string ExpectedCreditorName = "GlobalSupply S.A.S.";
    private const string ExpectedUetr2 = "b1c2d3e4-f5a6-4890-abcd-ef1234567890";
    private const string ExpectedEndToEndId2 = "ACME/INV-2024-848/PAY002";

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

    // ── Deserialize ────────────────────────────────────────────────────────────

    /// <summary>
    /// Verifies that the group header fields deserialize correctly: message ID,
    /// number of transactions, and the initiating party name.
    /// </summary>
    [Fact]
    public void Deserialize_GroupHeader_HasCorrectMsgId()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal("2", result.GroupHeader.NumberOfTransactions);
        Assert.Equal(ExpectedDebtorName, result.GroupHeader.InitiatingParty.Name);
    }

    /// <summary>
    /// Verifies that the payment information block (scalar) deserializes correctly:
    /// payment info ID, debtor name, and debtor account IBAN.
    /// </summary>
    [Fact]
    public void Deserialize_PaymentInfo_HasCorrectIdentifiers()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        var pmtInf = result.PaymentInformation;
        Assert.Equal(ExpectedPmtInfId, pmtInf.PaymentInformationIdentification);
        Assert.Equal(ExpectedDebtorName, pmtInf.Debtor.Name);

        var iban = Assert.IsType<IbanChoice>(pmtInf.DebtorAccount.Identification);
        Assert.Equal(ExpectedDebtorIban, iban.Value);
    }

    /// <summary>
    /// Verifies that both <c>&lt;CdtTrfTxInf&gt;</c> elements deserialize into the
    /// <see cref="PaymentInstruction40.CreditTransferTransactionInformation"/> collection.
    /// </summary>
    [Fact]
    public void Deserialize_TwoCreditTransfers_BothPresent()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        Assert.Equal(2, result.PaymentInformation.CreditTransferTransactionInformation.Count);
    }

    /// <summary>
    /// Verifies the first credit transfer's payment identifiers (UETR and EndToEndId)
    /// and the creditor name.
    /// </summary>
    [Fact]
    public void Deserialize_FirstTransfer_HasCorrectIds()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        var tx1 = result.PaymentInformation.CreditTransferTransactionInformation[0];
        Assert.Equal(ExpectedUetr1, tx1.PaymentIdentification.UETR);
        Assert.Equal(ExpectedEndToEndId1, tx1.PaymentIdentification.EndToEndIdentification);
        Assert.Equal(ExpectedCreditorName, tx1.Creditor?.Name);
    }

    /// <summary>
    /// Verifies the second credit transfer has different payment identifiers from
    /// the first, confirming two independent transactions were deserialized.
    /// </summary>
    [Fact]
    public void Deserialize_SecondTransfer_HasDifferentIds()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        var tx2 = result.PaymentInformation.CreditTransferTransactionInformation[1];
        Assert.Equal(ExpectedUetr2, tx2.PaymentIdentification.UETR);
        Assert.Equal(ExpectedEndToEndId2, tx2.PaymentIdentification.EndToEndIdentification);
    }

    /// <summary>
    /// Verifies the first transfer's remittance information has two unstructured lines.
    /// </summary>
    [Fact]
    public void Deserialize_RemittanceInfo_HasTwoLines()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        var tx1 = result.PaymentInformation.CreditTransferTransactionInformation[0];
        Assert.NotNull(tx1.RemittanceInformation);
        Assert.Equal(2, tx1.RemittanceInformation!.Unstructured.Count);
    }

    // ── Round-trip ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Deserialize → serialize → deserialize. Both credit transfers must survive
    /// the round-trip with their payment identifiers intact.
    /// </summary>
    [Fact]
    public void RoundTrip_TwoCreditTransfers_BothSurvive()
    {
        var original = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<CustomerCreditTransferInitiationV11>(xml);

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(2, result.PaymentInformation.CreditTransferTransactionInformation.Count);

        var tx1 = result.PaymentInformation.CreditTransferTransactionInformation[0];
        var tx2 = result.PaymentInformation.CreditTransferTransactionInformation[1];

        Assert.Equal(ExpectedUetr1, tx1.PaymentIdentification.UETR);
        Assert.Equal(ExpectedEndToEndId1, tx1.PaymentIdentification.EndToEndIdentification);
        Assert.Equal(2, tx1.RemittanceInformation!.Unstructured.Count);

        Assert.Equal(ExpectedUetr2, tx2.PaymentIdentification.UETR);
        Assert.Equal(ExpectedEndToEndId2, tx2.PaymentIdentification.EndToEndIdentification);
    }
}
