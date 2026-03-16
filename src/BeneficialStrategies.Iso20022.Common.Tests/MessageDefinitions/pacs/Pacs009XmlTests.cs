// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : https://www.iso20022.org/sites/default/files/schemas/pacs.009.001.12.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Embedded-resource XML tests for <see cref="FinancialInstitutionCreditTransferV12"/>
/// (pacs.009.001.12 — Financial Institution Credit Transfer).
///
/// The sample file <c>TestData/pacs.009.001.12_sample.xml</c> exercises:
/// - Full GrpHdr with SttlmInf (CLRG), InstgAgt, InstdAgt
/// - CdtTrfTxInf with optional DbtrAcct, CdtrAcct, IntrmyAgt1
/// - COLLECTION: InstrForCdtrAgt with 2 items (CHQB and HOLD)
/// - Round-trip serialization preserves key fields
/// </summary>
public class Pacs009XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pacs.009.001.12_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "DEUTDEFF/240315/PAC009/00001";
    private const string ExpectedEndToEndId = "NOSTRO-REBAL-20240315-001";
    private const string ExpectedUetr = "a3c8e91f-2b4d-4f67-8e9a-bc1234567890";
    private const string ExpectedDebtorBic = "DEUTDEFFXXX";

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
    /// Verifies that the GrpHdr deserializes with the correct MsgId, NbOfTxs,
    /// and settlement method (CLRG).
    /// </summary>
    [Fact]
    public void Deserialize_GroupHeader_HasCorrectIds()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(doc);

        Assert.NotNull(result);
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal("1", result.GroupHeader.NumberOfTransactions);
        Assert.Equal(
            SettlementMethod1Code.ClearingSystem,
            result.GroupHeader.SettlementInformation.SettlementMethod
        );
    }

    /// <summary>
    /// Verifies that the CdtTrfTxInf payment identification fields (EndToEndId,
    /// UETR) deserialize correctly.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_HasCorrectPaymentId()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(doc);
        var pmtId = result.CreditTransferTransactionInformation[0].PaymentIdentification;

        Assert.Equal(ExpectedEndToEndId, pmtId.EndToEndIdentification);
        Assert.Equal(ExpectedUetr, pmtId.UETR);
    }

    /// <summary>
    /// Verifies that the debtor is a financial institution identified by BICFI.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_Debtor_IsFI()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(doc);
        var debtor = result.CreditTransferTransactionInformation[0].Debtor;

        Assert.Equal(
            ExpectedDebtorBic,
            debtor.FinancialInstitutionIdentification.BICFI
        );
    }

    /// <summary>
    /// Verifies that two <c>&lt;InstrForCdtrAgt&gt;</c> elements deserialize to
    /// a collection of 2, with the first item having code CHQB.
    /// </summary>
    [Fact]
    public void Deserialize_CreditTransfer_TwoInstructionsForCreditorAgent()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(doc);
        var instructions =
            result.CreditTransferTransactionInformation[0].InstructionForCreditorAgent;

        Assert.Equal(2, instructions.Count);
        Assert.Equal(
            ExternalCreditorAgentInstruction1Code.PayCreditorByCheque,
            instructions[0].Code
        );
    }

    // ── Round-trip ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Deserialize → SerializeToString → deserialize. Key fields must survive
    /// the round-trip with identical values.
    /// </summary>
    [Fact]
    public void RoundTrip_PreservesKeyFields()
    {
        var original = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        Assert.False(string.IsNullOrWhiteSpace(xml));

        var result = Iso20022XmlSerializer.Deserialize<FinancialInstitutionCreditTransferV12>(xml);

        Assert.NotNull(result);

        // Group header
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            SettlementMethod1Code.ClearingSystem,
            result.GroupHeader.SettlementInformation.SettlementMethod
        );

        // Payment identification
        var pmtId = result.CreditTransferTransactionInformation[0].PaymentIdentification;
        Assert.Equal(ExpectedEndToEndId, pmtId.EndToEndIdentification);
        Assert.Equal(ExpectedUetr, pmtId.UETR);

        // Debtor BICFI
        Assert.Equal(
            ExpectedDebtorBic,
            result.CreditTransferTransactionInformation[0].Debtor.FinancialInstitutionIdentification.BICFI
        );

        // Collection
        Assert.Equal(
            2,
            result.CreditTransferTransactionInformation[0].InstructionForCreditorAgent.Count
        );
    }
}
