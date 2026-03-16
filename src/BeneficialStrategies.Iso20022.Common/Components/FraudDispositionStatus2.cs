// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Disposition of previously submitted fraud report message.
/// </summary>
[IsoId("_tyAHATHUEeyTT91yHXSlSQ")]
[DisplayName("Fraud Disposition Status")]
public record FraudDispositionStatus2
{
    /// <summary>
    /// Indicates the action taken as a disposition of the previously fraud report message.
    /// </summary>
    [IsoId("_t4meQTHUEeyTT91yHXSlSQ")]
    [DisplayName("Action Taken")]
    [IsoXmlTag("ActnTaken")]
    public required ActionTaken1Code ActionTaken { get; init; }

    /// <summary>
    /// Other action taken as defined at national or private level.
    /// </summary>
    [IsoId("_t4meQzHUEeyTT91yHXSlSQ")]
    [DisplayName("Other Action Taken")]
    [IsoXmlTag("OthrActnTaken")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherActionTaken { get; init; }

    /// <summary>
    /// Contains errors found in the submitted fraud report message.
    /// </summary>
    [IsoId("_t4meRTHUEeyTT91yHXSlSQ")]
    [DisplayName("Error Data")]
    [IsoXmlTag("ErrData")]
    public SimpleValueList<IsoMax256Text> ErrorData { get; init; } = [];

    /// <summary>
    /// Contains warnings found in the submitted fraud report message.
    /// </summary>
    [IsoId("_t4meRzHUEeyTT91yHXSlSQ")]
    [DisplayName("Warning Data")]
    [IsoXmlTag("WrngData")]
    public SimpleValueList<IsoMax256Text> WarningData { get; init; } = [];

    /// <summary>
    /// Additional information
    /// </summary>
    [IsoId("_t4meSTHUEeyTT91yHXSlSQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation30> AdditionalInformation { get; init; } = [];
}
