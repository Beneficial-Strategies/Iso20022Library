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
/// Content of the EventNotification message.
/// </summary>
[IsoId("_vNo2IN6ZEeiwsev40qZGEQ")]
[DisplayName("Event Notification Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventNotificationData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventNotificationData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventNotificationData1( RetailerEvent1 reqRetailerEvent )
    {
        RetailerEvent = reqRetailerEvent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_RT-CQN6aEeiwsev40qZGEQ")]
    [DisplayName("Retailer Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtlrEvt")]
    #endif
    [IsoXmlTag("RtlrEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerEvent1 RetailerEvent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerEvent1 RetailerEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerEvent1 RetailerEvent { get; init; } 
    #else
    public RetailerEvent1 RetailerEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_OJ_usN6cEeiwsev40qZGEQ")]
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
    [IsoId("_QdmJAN6cEeiwsev40qZGEQ")]
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
    [IsoId("_TLkyMN6cEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage6? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage6? DisplayOutput { get; init; } 
    #else
    public ActionMessage6? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
