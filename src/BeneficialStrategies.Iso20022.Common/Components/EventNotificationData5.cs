// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specificies all information around an event notification.
/// </summary>
[IsoId("_QfRfoXJeEe299ZbWCkdR_w")]
[DisplayName("Event Notification Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventNotificationData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventNotificationData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventNotificationData5( RetailerEvent5 reqRetailerEvent )
    {
        RetailerEvent = reqRetailerEvent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_QlqbgXJeEe299ZbWCkdR_w")]
    [DisplayName("Retailer Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtlrEvt")]
    #endif
    [IsoXmlTag("RtlrEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerEvent5 RetailerEvent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerEvent5 RetailerEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerEvent5 RetailerEvent { get; init; } 
    #else
    public RetailerEvent5 RetailerEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_Qlqbg3JeEe299ZbWCkdR_w")]
    [DisplayName("Maintenance Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncReqrdFlg")]
    #endif
    [IsoXmlTag("MntncReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaintenanceRequiredFlag { get; init; } 
    #else
    public System.String? MaintenanceRequiredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the Customer
    /// </summary>
    [IsoId("_QlqbhXJeEe299ZbWCkdR_w")]
    [DisplayName("Customer Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrLang")]
    #endif
    [IsoXmlTag("CstmrLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? CustomerLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CustomerLanguage { get; init; } 
    #else
    public string? CustomerLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// To display an event message
    /// </summary>
    [IsoId("_Qlqbh3JeEe299ZbWCkdR_w")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? DisplayOutput { get; init; } 
    #else
    public ActionMessage10? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
