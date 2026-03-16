// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on an event occurring in a system, whether planned or unplanned as stipulated in the specifications of the system.
/// </summary>
[IsoId("_8FSRsqMgEeCJ6YNENx4h-w_-140040828")]
[DisplayName("System Event")]
public record SystemEvent2
{
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_8FSRs6MgEeCJ6YNENx4h-w_-338099461")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemEventType2Choice_ Type { get; init; }

    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    [IsoId("_8FSRtKMgEeCJ6YNENx4h-w_-2003849778")]
    [DisplayName("Scheduled Time")]
    [IsoXmlTag("SchdldTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ScheduledTime { get; init; }

    /// <summary>
    /// Date and time at which the event effectively takes place.
    /// </summary>
    [IsoId("_8FSRtaMgEeCJ6YNENx4h-w_-1560861286")]
    [DisplayName("Effective Time")]
    [IsoXmlTag("FctvTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EffectiveTime { get; init; }

    /// <summary>
    /// Time at which the event starts.
    /// </summary>
    [IsoId("_8FSRtqMgEeCJ6YNENx4h-w_863262048")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; }

    /// <summary>
    /// Time at which the event ends.
    /// </summary>
    [IsoId("_8FSRt6MgEeCJ6YNENx4h-w_-181798605")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; }
}
