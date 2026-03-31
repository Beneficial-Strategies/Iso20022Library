// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dispute Data4.
/// </summary>
[IsoId("_kfXKsXHDEe60F8I8TAMKmg")]
[DisplayName("Dispute Data4")]
public record DisputeData4
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Chargeback Eligibility.
    /// </summary>
    [DisplayName("Chargeback Eligibility")]
    [IsoXmlTag("ChrgbckElgblty")]
    public IsoMax35Text? ChargebackEligibility { get; init; }

    /// <summary>
    /// Condition.
    /// </summary>
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public IsoMax35Text? Condition { get; init; }

    /// <summary>
    /// Cycle.
    /// </summary>
    [DisplayName("Cycle")]
    [IsoXmlTag("Cycl")]
    public IsoExact1NumericText? Cycle { get; init; }

    /// <summary>
    /// Documentation Status.
    /// </summary>
    [DisplayName("Documentation Status")]
    [IsoXmlTag("DcmnttnSts")]
    public IsoMax35Text? DocumentationStatus { get; init; }

    /// <summary>
    /// Partial.
    /// </summary>
    [DisplayName("Partial")]
    [IsoXmlTag("Prtl")]
    public IsoTrueFalseIndicator? Partial { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public ValueList<DisputeReference1> Reference { get; init; } = [];

    /// <summary>
    /// Reject Reason.
    /// </summary>
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public ValueList<IsoMax35Text> RejectReason { get; init; } = [];

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IsoMax35Text? Status { get; init; }
}
