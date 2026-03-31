// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters defining the timing conditions to process an action.
/// </summary>
[IsoId("_vIQrUXh2EeStacoNRHtESA")]
[DisplayName("Process Timing")]
public record ProcessTiming4
{
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_vVWsI3h2EeStacoNRHtESA")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; }

    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    [IsoId("_vVWsJXh2EeStacoNRHtESA")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; }

    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_vVWsJ3h2EeStacoNRHtESA")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? Period { get; init; }
}
