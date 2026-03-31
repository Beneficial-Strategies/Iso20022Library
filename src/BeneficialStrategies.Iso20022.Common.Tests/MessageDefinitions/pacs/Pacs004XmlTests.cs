// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: VALID
// Validated : 2026-03-16
// Schema    : https://www.iso20022.org/sites/default/files/schemas/pacs.004.001.14.xsd

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.pacs;

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// Embedded-resource XML tests for <see cref="PaymentReturnV14"/>.
///
/// The sample file <c>TestData/pacs.004.001.14_sample.xml</c> is pending external
/// validation against the ISO 20022 XSD (see file header for details).
/// Tests verify deserialization from that canonical file and that a deserialized
/// record can be re-serialized and re-deserialized without data loss.
/// </summary>
public class Pacs004XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pacs.004.001.14_sample.xml";

    private const string ExpectedMsgId = "BNPAFRPP/240316/PAC004/00001";
    private const string ExpectedInstgAgtBic = "BNPAFRPPXXX";
    private const string ExpectedInstdAgtBic = "DEUTDEFFXXX";
    private const string ExpectedOrgnlMsgId = "DEUTDEFF/240315/PAC008/00001";
    private const string ExpectedOrgnlMsgNmId = "pacs.008.001.13";
    private const string ExpectedRtrId = "BNPAFRPP/240316/RET/00001";
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

        var result = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(doc);

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

        var result = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(doc);

        Assert.NotNull(result);
        var orgnl = result.OriginalGroupInformation;
        Assert.NotNull(orgnl);
        Assert.Equal(ExpectedOrgnlMsgId, orgnl!.OriginalMessageIdentification);
        Assert.Equal(ExpectedOrgnlMsgNmId, orgnl.OriginalMessageNameIdentification);
    }

    [Fact]
    public void Deserialize_TransactionInfo_HasCorrectIds()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(doc);

        Assert.NotNull(result);
        var txInf = result.TransactionInformation;
        Assert.NotEmpty(txInf);
        Assert.Equal(ExpectedRtrId, txInf[0].ReturnIdentification);
        Assert.Equal(ExpectedEndToEndId, txInf[0].OriginalEndToEndIdentification);
        Assert.Equal(ExpectedUetr, txInf[0].OriginalUETR);
    }

    [Fact]
    public void Deserialize_TransactionInfo_TwoReturnReasons()
    {
        var doc = LoadEmbeddedXml();

        var result = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(doc);

        Assert.NotNull(result);
        var txInf = result.TransactionInformation;
        Assert.NotEmpty(txInf);
        Assert.Equal(2, txInf[0].ReturnReasonInformation.Count);
        var firstReason = Assert.IsType<Code>(txInf[0].ReturnReasonInformation[0].Reason);
        Assert.Equal(ExternalReturnReason1Code.RequestedByCustomer, firstReason.Value);
        var secondReason = Assert.IsType<Code>(txInf[0].ReturnReasonInformation[1].Reason);
        Assert.Equal(ExternalReturnReason1Code.Narrative, secondReason.Value);
    }

    [Fact]
    public void RoundTrip_PreservesKeyFields()
    {
        var doc = LoadEmbeddedXml();
        var original = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(doc);

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        Assert.False(string.IsNullOrWhiteSpace(xml));

        var result = Iso20022XmlSerializer.Deserialize<PaymentReturnV14>(xml);

        Assert.NotNull(result);
        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            ExpectedInstgAgtBic,
            result.GroupHeader.InstructingAgent!.FinancialInstitutionIdentification.BICFI
        );
        var txInf = result.TransactionInformation;
        Assert.NotEmpty(txInf);
        Assert.Equal(ExpectedRtrId, txInf[0].ReturnIdentification);
        Assert.Equal(ExpectedUetr, txInf[0].OriginalUETR);
        Assert.Equal(2, txInf[0].ReturnReasonInformation.Count);
    }
}
