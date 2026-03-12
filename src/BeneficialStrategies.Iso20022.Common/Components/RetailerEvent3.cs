// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Retailer Event message.
/// </summary>
[IsoId("_Cnm_wS8SEeu125Ip9zFcsQ")]
[DisplayName("Retailer Event")]
public partial record RetailerEvent3
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_CzHsMS8SEeu125Ip9zFcsQ")]
    [DisplayName("Event Time Stamp")]
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTimeStamp { get; init; } 
    
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_CzHsMy8SEeu125Ip9zFcsQ")]
    [DisplayName("Event To Notify")]
    [IsoXmlTag("EvtToNtfy")]
    public required EventToNotify2Code EventToNotify { get; init; } 
    
    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_CzHsNS8SEeu125Ip9zFcsQ")]
    [DisplayName("Event Context")]
    [IsoXmlTag("EvtCntxt")]
    public EventContext3? EventContext { get; init; } 
    
    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_CzHsNy8SEeu125Ip9zFcsQ")]
    [DisplayName("Additional Event Information")]
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? AdditionalEventInformation { get; init; } 
    
    
    #nullable disable
    
}
