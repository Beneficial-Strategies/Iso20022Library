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
[IsoId("_MWeUsQ0uEeqUVL7sB4m7NA")]
[DisplayName("Retailer Event")]
public record RetailerEvent2
{
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_Mh790Q0uEeqUVL7sB4m7NA")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTimeStamp { get; init; }

    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_Mh790w0uEeqUVL7sB4m7NA")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; }

    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_Mh791Q0uEeqUVL7sB4m7NA")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext2? EventContext { get; init; }

    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_Mh791w0uEeqUVL7sB4m7NA")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalEventInformation { get; init; }
}
