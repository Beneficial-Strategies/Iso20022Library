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
[IsoId("_QV5csVFBEeyApZmLzm74zA")]
[DisplayName("Retailer Event")]
public record RetailerEvent4
{
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_QcP8UVFBEeyApZmLzm74zA")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTimeStamp { get; init; }

    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_QcP8U1FBEeyApZmLzm74zA")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; }

    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_QcP8VVFBEeyApZmLzm74zA")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext4? EventContext { get; init; }

    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_QcP8V1FBEeyApZmLzm74zA")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalEventInformation { get; init; }
}
