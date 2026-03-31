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
[IsoId("_aZLdATAOEeugIJ3Gvoevmg")]
[DisplayName("Process Timing")]
public record ProcessTiming5
{
    /// <summary>
    /// Waiting time after the previous action in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_amjxsTAOEeugIJ3Gvoevmg")]
    [DisplayName("Waiting Time")]
    [IsoXmlTag("WtgTm")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? WaitingTime { get; init; }

    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_amjxszAOEeugIJ3Gvoevmg")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; }

    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    [IsoId("_amjxtTAOEeugIJ3Gvoevmg")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; }

    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_amjxtzAOEeugIJ3Gvoevmg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? Period { get; init; }

    /// <summary>
    /// Maximum number of cyclic calls.
    /// </summary>
    [IsoId("_amjxuTAOEeugIJ3Gvoevmg")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; }

    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    [IsoId("_zQi_MDAOEeugIJ3Gvoevmg")]
    [DisplayName("Unit Of Time")]
    [IsoXmlTag("UnitOfTm")]
    public TimeUnit1Code? UnitOfTime { get; init; }
}
