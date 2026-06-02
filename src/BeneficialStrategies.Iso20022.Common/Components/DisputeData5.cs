// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to be present in a dispute.
/// </summary>
[IsoId("_pkC1gRT_EfC_aaedwHHlmw")]
[DisplayName("Dispute Data5")]
public record DisputeData5
{
    /// <summary>
    /// Indicates the cycle of presentment.
    /// </summary>
    [IsoId("_pq7goRT_EfC_aaedwHHlmw")]
    [DisplayName("Cycle")]
    [IsoXmlTag("Cycl")]
    public IsoExact1NumericText? Cycle { get; init; }

    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_pq7goxT_EfC_aaedwHHlmw")]
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public IsoMax35Text? Condition { get; init; }

    /// <summary>
    /// Status of dispute.
    /// </summary>
    [IsoId("_pq7gpRT_EfC_aaedwHHlmw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IsoMax35Text? Status { get; init; }

    /// <summary>
    /// Partial dispute indicator.
    /// </summary>
    [IsoId("_pq7gpxT_EfC_aaedwHHlmw")]
    [DisplayName("Partial")]
    [IsoXmlTag("Prtl")]
    public IsoTrueFalseIndicator? Partial { get; init; }

    /// <summary>
    /// Bundle dispute case reference assigned by agent.
    /// </summary>
    [IsoId("_2bohERUBEfC_aaedwHHlmw")]
    [DisplayName("Agent Bundle Case Reference")]
    [IsoXmlTag("AgtBndlCaseRef")]
    public IsoMax20Text? AgentBundleCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by agent.
    /// </summary>
    [IsoId("_1mYUEBUBEfC_aaedwHHlmw")]
    [DisplayName("Agent Case Reference")]
    [IsoXmlTag("AgtCaseRef")]
    public IsoMax20Text? AgentCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by acquirer.
    /// </summary>
    [IsoId("_4CyFERUBEfC_aaedwHHlmw")]
    [DisplayName("Acquirer Case Reference")]
    [IsoXmlTag("AcqrrCaseRef")]
    public IsoMax20Text? AcquirerCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by issuer.
    /// </summary>
    [IsoId("_4qDgcRUBEfC_aaedwHHlmw")]
    [DisplayName("Issuer Case Reference")]
    [IsoXmlTag("IssrCaseRef")]
    public IsoMax20Text? IssuerCaseReference { get; init; }

    /// <summary>
    /// Status of the dispute documentation.
    /// </summary>
    [IsoId("_pq7gqxT_EfC_aaedwHHlmw")]
    [DisplayName("Documentation Status")]
    [IsoXmlTag("DcmnttnSts")]
    public IsoMax35Text? DocumentationStatus { get; init; }

    /// <summary>
    /// Reason for rejecting a dispute.
    /// </summary>
    [IsoId("_pq7grRT_EfC_aaedwHHlmw")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public SimpleValueList<IsoMax35Text> RejectReason { get; init; } = [];

    /// <summary>
    /// Provides transaction chargeback eligibility conditions.
    /// </summary>
    [IsoId("_pq7grxT_EfC_aaedwHHlmw")]
    [DisplayName("Chargeback Eligibility")]
    [IsoXmlTag("ChrgbckElgblty")]
    public IsoMax35Text? ChargebackEligibility { get; init; }

    /// <summary>
    /// Brief unformatted text describing a dispute.
    /// </summary>
    [IsoId("_6kgs4BT_EfC_aaedwHHlmw")]
    [DisplayName("Message Text")]
    [IsoXmlTag("MsgTxt")]
    public IsoMax50Text? MessageText { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_lxWUwmvXEfCyxsm1jzUNug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_lxWUw2vXEfCyxsm1jzUNug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
