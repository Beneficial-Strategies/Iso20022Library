// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies all information related to an event.
/// </summary>
[IsoId("_VaUSwXJdEe299ZbWCkdR_w")]
[DisplayName("Retailer Event")]
public partial record RetailerEvent5
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_VhLIsXJdEe299ZbWCkdR_w")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTimeStamp { get; init; } 
    
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_VhLIs3JdEe299ZbWCkdR_w")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; } 
    
    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_VhLItXJdEe299ZbWCkdR_w")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext5? EventContext { get; init; } 
    
    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_VhLIt3JdEe299ZbWCkdR_w")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? AdditionalEventInformation { get; init; } 
    
    
    #nullable disable
    
}
