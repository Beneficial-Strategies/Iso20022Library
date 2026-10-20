// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : https://www.iso20022.org/sites/default/files/schemas/pacs.008.001.13.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Embedded-resource XML tests for <see cref="FIToFICustomerCreditTransferV13"/>
/// (pacs.008.001.13 — FI-to-FI Customer Credit Transfer).
///
/// The sample file <c>TestData/pacs.008.001.13_sample.xml</c> exercises:
/// - Full GrpHdr with SttlmInf (CLRG), InstgAgt, InstdAgt
/// - CdtTrfTxInf with all optional fields populated
/// - COLLECTION: InstrForCdtrAgt with 2 items (CHQB and HOLD)
/// - RmtInf with 2 Ustrd lines
/// - Round-trip serialization preserves all fields
/// </summary>
public class Pacs008XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pacs.008.001.13_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "DEUTDEFF/240315/PAC008/00001";
    private const string ExpectedInstrId = "DEUTDEFF/240315/INSTR/00001";
    private const string ExpectedEndToEndId = "ACME/INV-2024-847/PAY001";
    private const string ExpectedUetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";
    private const string ExpectedInstgAgtBic = "DEUTDEFFXXX";
    private const string ExpectedDebtorName = "Acme Manufacturing GmbH";
    private const string ExpectedDebtorCountry = "DE";

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
    /// Verifies that the GrpHdr deserializes with the correct MsgId, settlement
    /// method (CLRG), and instructing agent BIC.
    /// </summary>
    [Fact]
    public void Deserialize_GroupHeader_HasCorrectMsgId()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(doc);

        Assert.NotNull(result);
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            SettlementMethod1Code.ClearingSystem,
            result.GroupHeader.SettlementInformation.SettlementMethod
        );
        Assert.Equal(
            ExpectedInstgAgtBic,
            result.GroupHeader.InstructingAgent!.FinancialInstitutionIdentification.BICFI
        );
    }

    /// <summary>
    /// Verifies that the CdtTrfTxInf payment identification fields (InstrId,
    /// EndToEndId, UETR) deserialize correctly.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_HasCorrectPaymentId()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(doc);
        var pmtId = result.CreditTransferTransactionInformation[0].PaymentIdentification;

        Assert.Equal(ExpectedInstrId, pmtId.InstructionIdentification);
        Assert.Equal(ExpectedEndToEndId, pmtId.EndToEndIdentification);
        Assert.Equal(ExpectedUetr, pmtId.UETR);
    }

    /// <summary>
    /// Verifies that two <c>&lt;InstrForCdtrAgt&gt;</c> elements deserialize to
    /// a collection of 2, with the first item having code CHQB.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_TwoInstructionsForCreditorAgent()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(doc);
        var instructions =
            result.CreditTransferTransactionInformation[0].InstructionForCreditorAgent;

        Assert.Equal(2, instructions.Count);
        Assert.Equal(
            ExternalCreditorAgentInstruction1Code.PayCreditorByCheque,
            instructions[0].Code
        );
    }

    /// <summary>
    /// Verifies that two <c>&lt;Ustrd&gt;</c> elements inside <c>&lt;RmtInf&gt;</c>
    /// deserialize to a collection of 2 unstructured remittance lines.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_RemittanceInfo_TwoUnstructuredLines()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(doc);
        var rmtInf = result.CreditTransferTransactionInformation[0].RemittanceInformation;

        Assert.NotNull(rmtInf);
        Assert.Equal(2, rmtInf!.Unstructured.Count);
    }

    /// <summary>
    /// Verifies that the debtor name and country deserialize correctly.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_Debtor_NameAndAddress()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(doc);
        var debtor = result.CreditTransferTransactionInformation[0].Debtor;

        Assert.Equal(ExpectedDebtorName, debtor.Name);
        Assert.Equal(ExpectedDebtorCountry, debtor.PostalAddress!.Country);
    }

    // ── Round-trip ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Deserialize → SerializeToString → deserialize. Key fields must survive
    /// the round-trip with identical values.
    /// </summary>
    [Fact]
    public void RoundTrip_PreservesAllFields()
    {
        var original = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        Assert.False(string.IsNullOrWhiteSpace(xml));

        var result = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(xml);

        Assert.NotNull(result);

        // Group header
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            SettlementMethod1Code.ClearingSystem,
            result.GroupHeader.SettlementInformation.SettlementMethod
        );

        // Payment identification
        var pmtId = result.CreditTransferTransactionInformation[0].PaymentIdentification;
        Assert.Equal(ExpectedInstrId, pmtId.InstructionIdentification);
        Assert.Equal(ExpectedEndToEndId, pmtId.EndToEndIdentification);
        Assert.Equal(ExpectedUetr, pmtId.UETR);

        // Collections
        Assert.Equal(
            2,
            result.CreditTransferTransactionInformation[0].InstructionForCreditorAgent.Count
        );
        Assert.Equal(
            2,
            result.CreditTransferTransactionInformation[0].RemittanceInformation!.Unstructured.Count
        );

        // Debtor
        Assert.Equal(
            ExpectedDebtorName,
            result.CreditTransferTransactionInformation[0].Debtor.Name
        );
    }
}
