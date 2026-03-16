// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// XSD VALIDATION STATUS: PENDING EXTERNAL VALIDATION
//
// Scenario: Deutsche Bank rejects the payment information block from Acme's pain.001 because
//           the creditor account was closed (AC04). The response carries two StsRsnInf items:
//           one with a standard code (AC04) and one with a proprietary reason (NARR).
//           Tests verify deserialization of scalar OriginalPaymentInformationAndStatus and
//           the ValueList<StatusReasonInformation12> StatusReasonInformation collection.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Embedded-resource XML tests for <see cref="CustomerPaymentStatusReportV13"/>
/// (pain.002.001.13 — Customer Payment Status Report).
///
/// The sample file contains a single <c>&lt;OrgnlPmtInfAndSts&gt;</c> block with
/// two <c>&lt;StsRsnInf&gt;</c> elements, verifying that:
/// <list type="bullet">
///   <item><see cref="CustomerPaymentStatusReportV13.OriginalPaymentInformationAndStatus"/>
///     is a scalar (not a collection).</item>
///   <item><see cref="OriginalPaymentInstruction45.StatusReasonInformation"/> is a
///     <c>ValueList&lt;StatusReasonInformation12&gt;</c> that populates both items.</item>
///   <item><see cref="StatusReasonInformation12.AdditionalInformation"/> is a
///     <c>SimpleValueList&lt;string&gt;</c> that populates multiple lines per item.</item>
/// </list>
/// </summary>
public class Pain002XmlTests
{
    private const string ResourceName =
        "BeneficialStrategies.Iso20022.TestData.pain.002.001.13_sample.xml";

    // ── Expected values ────────────────────────────────────────────────────────

    private const string ExpectedMsgId = "DEUTDEFF/240315/PAI002/00001";
    private const string ExpectedOriginalMsgId = "ACME/240315/PAI001/00001";
    private const string ExpectedOriginalPmtInfId = "ACME/240315/PMTINF/001";

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
    /// Verifies that the group header message identifier and debtor agent BIC
    /// deserialize correctly.
    /// </summary>
    [Fact]
    public void Deserialize_GroupHeader_HasCorrectMsgId()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            "DEUTDEFFXXX",
            result.GroupHeader.DebtorAgent?.FinancialInstitutionIdentification.BICFI
        );
    }

    /// <summary>
    /// Verifies the original group information: original message ID and the
    /// group status code (PART = partially accepted).
    /// </summary>
    [Fact]
    public void Deserialize_OriginalGroupInfo_HasCorrectMsgId()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        var grpInfo = result.OriginalGroupInformationAndStatus;
        Assert.Equal(ExpectedOriginalMsgId, grpInfo.OriginalMessageIdentification);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.PartiallyAccepted,
            grpInfo.GroupStatus
        );
    }

    /// <summary>
    /// Verifies that two <c>&lt;StsRsnInf&gt;</c> elements deserialize into the
    /// <see cref="OriginalPaymentInstruction45.StatusReasonInformation"/> collection,
    /// and that the first item carries the AC04 status reason code.
    /// </summary>
    [Fact]
    public void Deserialize_OriginalPaymentInfo_TwoStatusReasons()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        var pmtInf = result.OriginalPaymentInformationAndStatus;
        Assert.NotNull(pmtInf);
        Assert.Equal(ExpectedOriginalPmtInfId, pmtInf!.OriginalPaymentInformationIdentification);
        Assert.Equal(2, pmtInf.StatusReasonInformation.Count);

        var firstReason = Assert.IsType<Code>(pmtInf.StatusReasonInformation[0].Reason);
        Assert.Equal(ExternalStatusReason1Code.ClosedAccountNumber, firstReason.Value);
    }

    /// <summary>
    /// Verifies the first status reason carries the Code variant with value AC04
    /// (ClosedAccountNumber).
    /// </summary>
    [Fact]
    public void Deserialize_FirstStatusReason_HasCodeAC04()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        var stsRsn1 = result.OriginalPaymentInformationAndStatus!.StatusReasonInformation[0];
        Assert.Equal("Deutsche Bank AG", stsRsn1.Originator?.Name);
        var code = Assert.IsType<Code>(stsRsn1.Reason);
        Assert.Equal(ExternalStatusReason1Code.ClosedAccountNumber, code.Value);
    }

    /// <summary>
    /// Verifies the first status reason's additional information has exactly two lines.
    /// </summary>
    [Fact]
    public void Deserialize_FirstStatusReason_AdditionalInformation_HasTwoLines()
    {
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        var stsRsn1 = result.OriginalPaymentInformationAndStatus!.StatusReasonInformation[0];
        Assert.Equal(2, stsRsn1.AdditionalInformation.Count);
        Assert.Equal("Account FR7630006000011234567890189 closed", stsRsn1.AdditionalInformation[0]);
        Assert.Equal("As of 2024-01-31", stsRsn1.AdditionalInformation[1]);
    }

    // ── Round-trip ─────────────────────────────────────────────────────────────

    /// <summary>
    /// Deserialize → serialize → deserialize. Key fields must survive the round-trip:
    /// group header message ID, original message ID, payment info status, and the
    /// two status reason items with their additional information lines.
    /// </summary>
    [Fact]
    public void RoundTrip_PreservesKeyFields()
    {
        var original = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(
            LoadEmbeddedXml()
        );

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var result = Iso20022XmlSerializer.Deserialize<CustomerPaymentStatusReportV13>(xml);

        Assert.Equal(ExpectedMsgId, result.GroupHeader.MessageIdentification);
        Assert.Equal(
            ExpectedOriginalMsgId,
            result.OriginalGroupInformationAndStatus.OriginalMessageIdentification
        );

        var pmtInf = result.OriginalPaymentInformationAndStatus;
        Assert.NotNull(pmtInf);
        Assert.Equal(
            ExternalPaymentGroupStatus1Code.Rejected,
            pmtInf!.PaymentInformationStatus
        );
        Assert.Equal(2, pmtInf.StatusReasonInformation.Count);
        Assert.Equal(2, pmtInf.StatusReasonInformation[0].AdditionalInformation.Count);
        Assert.Equal(1, pmtInf.StatusReasonInformation[1].AdditionalInformation.Count);
    }
}
