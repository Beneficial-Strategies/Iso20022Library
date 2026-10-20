// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : https://www.iso20022.org/sites/default/files/schemas/pacs.002.001.15.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Embedded-resource XML tests for <see cref="FIToFIPaymentStatusReportV15"/>.
///
/// The sample file <c>TestData/pacs.002.001.15_sample.xml</c> is pending external
/// validation against the ISO 20022 XSD (see file header for details).
/// Tests verify deserialization from that canonical file and that a deserialized
/// record can be re-serialized and re-deserialized without data loss.
/// </summary>
public class Pacs002XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pacs.002.001.15_sample.xml";

    private const string ExpectedMsgId = "BNPAFRPP/240315/PAC002/00001";
    private const string ExpectedInstgAgtBic = "BNPAFRPPXXX";
    private const string ExpectedInstdAgtBic = "DEUTDEFFXXX";
    private const string ExpectedOrgnlMsgId = "DEUTDEFF/240315/PAC008/00001";
    private const string ExpectedOrgnlMsgNmId = "pacs.008.001.13";
    private const string ExpectedEndToEndId = "ACME/INV-2024-847/PAY001";
    private const string ExpectedUetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";

    // ── Helpers ────────────────────────────────────────────────────────────────

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

    // ── Deserialize from embedded resource ────────────────────────────────────

    [Fact]
    public void Deserialize_GroupHeader_HasCorrectIds()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentStatusReportV15>(doc);

        Assert.NotNull(result);
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            ExpectedInstgAgtBic,
            result.GroupHeader.InstructingAgent!.FinancialInstitutionIdentification.BICFI
        );
        Assert.Equal(
            ExpectedInstdAgtBic,
            result.GroupHeader.InstructedAgent!.FinancialInstitutionIdentification.BICFI
        );
    }

    [Fact]
    public void Deserialize_OriginalGroupInfo_HasCorrectMsgId()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentStatusReportV15>(doc);

        Assert.NotNull(result);
        var orgnl = result.OriginalGroupInformationAndStatus;
        Assert.NotEmpty(orgnl);
        Assert.Equal(ExpectedOrgnlMsgId, orgnl[0].OriginalMessageIdentification);
        Assert.Equal(ExpectedOrgnlMsgNmId, orgnl[0].OriginalMessageNameIdentification);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.AcceptedCustomerProfile,
            orgnl[0].GroupStatus
        );
    }

    [Fact]
    public void Deserialize_TransactionStatus_ACSP_WithTwoStatusReasons()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentStatusReportV15>(doc);

        Assert.NotNull(result);
        var txInf = result.TransactionInformationAndStatus;
        Assert.NotEmpty(txInf);
        Assert.Equal(ExpectedEndToEndId, txInf[0].OriginalEndToEndIdentification);
        Assert.Equal(ExpectedUetr, txInf[0].OriginalUETR);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.AcceptedSettlementInProcess,
            txInf[0].TransactionStatus
        );
        Assert.Equal(2, txInf[0].StatusReasonInformation.Count);
        var reason0 = Assert.IsType<Proprietary>(txInf[0].StatusReasonInformation[0].Reason);
        Assert.Equal("ACCEPTED-CLEARING", reason0.Value);
        var reason1 = Assert.IsType<Proprietary>(txInf[0].StatusReasonInformation[1].Reason);
        Assert.Equal("SETTLEMENT-INITIATED", reason1.Value);
    }

    [Fact]
    public void RoundTrip_PreservesKeyFields()
    {
        var doc = LoadEmbeddedXml();
        var original = Iso20022XmlSerializer.Deserialize<FIToFIPaymentStatusReportV15>(doc);

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        Assert.False(string.IsNullOrWhiteSpace(xml));

        var result = Iso20022XmlSerializer.Deserialize<FIToFIPaymentStatusReportV15>(xml);

        Assert.NotNull(result);
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            ExpectedInstgAgtBic,
            result.GroupHeader.InstructingAgent!.FinancialInstitutionIdentification.BICFI
        );
        var txInf = result.TransactionInformationAndStatus;
        Assert.NotEmpty(txInf);
        Assert.Equal(ExpectedUetr, txInf[0].OriginalUETR);
        Assert.Equal(
            ExternalPaymentTransactionStatus1Code.AcceptedSettlementInProcess,
            txInf[0].TransactionStatus
        );
        Assert.Equal(2, txInf[0].StatusReasonInformation.Count);
    }
}
