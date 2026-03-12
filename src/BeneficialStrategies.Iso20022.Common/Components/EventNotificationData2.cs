// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the EventNotification message.
/// </summary>
[IsoId("_HUBHcQ0uEeqUVL7sB4m7NA")]
[DisplayName("Event Notification Data")]
public partial record EventNotificationData2
{
    #nullable enable
    
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_HfjpEQ0uEeqUVL7sB4m7NA")]
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent2 RetailerEvent { get; init; } 
    
    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_HfjpEw0uEeqUVL7sB4m7NA")]
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; } 
    
    /// <summary>
    /// Language of the Customer
    /// </summary>
    [IsoId("_HfjpFQ0uEeqUVL7sB4m7NA")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; } 
    
    /// <summary>
    /// To display an event message
    /// </summary>
    [IsoId("_HfjpFw0uEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage7? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
