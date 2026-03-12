// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specificies all information around an event notification.
/// </summary>
[IsoId("_QfRfoXJeEe299ZbWCkdR_w")]
[DisplayName("Event Notification Data")]
public partial record EventNotificationData5
{
    #nullable enable
    
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_QlqbgXJeEe299ZbWCkdR_w")]
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent5 RetailerEvent { get; init; } 
    
    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_Qlqbg3JeEe299ZbWCkdR_w")]
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; } 
    
    /// <summary>
    /// Language of the Customer
    /// </summary>
    [IsoId("_QlqbhXJeEe299ZbWCkdR_w")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; } 
    
    /// <summary>
    /// To display an event message
    /// </summary>
    [IsoId("_Qlqbh3JeEe299ZbWCkdR_w")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage10? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
