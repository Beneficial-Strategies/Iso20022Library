// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Retailer Event message.
/// </summary>
[IsoId("_TT2PUN6aEeiwsev40qZGEQ")]
[DisplayName("Retailer Event")]
public record RetailerEvent1
{
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_ZHTbsN6aEeiwsev40qZGEQ")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTimeStamp { get; init; }

    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_bTTZMN6aEeiwsev40qZGEQ")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify1Code EventToNotify { get; init; }

    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_sl3QsN6bEeiwsev40qZGEQ")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext1? EventContext { get; init; }

    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_IeTXMN6cEeiwsev40qZGEQ")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalEventInformation { get; init; }
}
