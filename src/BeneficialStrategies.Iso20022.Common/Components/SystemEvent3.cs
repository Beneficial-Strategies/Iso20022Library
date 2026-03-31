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
[IsoId("_dw2Oi3hkEeidzqjNEfehPg")]
[DisplayName("System Event")]
public record SystemEvent3
{
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_d6_pA3hkEeidzqjNEfehPg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemEventType4Choice_ Type { get; init; }

    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    [IsoId("_d6_pBXhkEeidzqjNEfehPg")]
    [DisplayName("Scheduled Time")]
    [IsoXmlTag("SchdldTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ScheduledTime { get; init; }

    /// <summary>
    /// Date and time at which the event effectively takes place.
    /// </summary>
    [IsoId("_d6_pB3hkEeidzqjNEfehPg")]
    [DisplayName("Effective Time")]
    [IsoXmlTag("FctvTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EffectiveTime { get; init; }

    /// <summary>
    /// Time at which the event starts.
    /// </summary>
    [IsoId("_d6_pCXhkEeidzqjNEfehPg")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; }

    /// <summary>
    /// Time at which the event ends.
    /// </summary>
    [IsoId("_d6_pC3hkEeidzqjNEfehPg")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; }
}
