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
/// Information about the cancellation of a notification advice or the withdrawal of a CA event.
/// </summary>
[IsoId("_Rjual9p-Ed-ak6NoX_4Aeg_493176942")]
[DisplayName("Notification Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotificationCancellation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NotificationCancellation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotificationCancellation1( CorporateActionNotificationType2Code reqNotificationCancellationType,DocumentIdentification8 reqLinkedAgentCANotificationAdviceIdentification )
    {
        NotificationCancellationType = reqNotificationCancellationType;
        LinkedAgentCANotificationAdviceIdentification = reqLinkedAgentCANotificationAdviceIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The function of the notification e.g. new notification.
    /// </summary>
    [IsoId("_RjuamNp-Ed-ak6NoX_4Aeg_959555478")]
    [DisplayName("Notification Cancellation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnCxlTp")]
    #endif
    [IsoXmlTag("NtfctnCxlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionNotificationType2Code NotificationCancellationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionNotificationType2Code NotificationCancellationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationType2Code NotificationCancellationType { get; init; } 
    #else
    public CorporateActionNotificationType2Code NotificationCancellationType { get; set; } 
    #endif
    
    /// <summary>
    /// The identification of the linked notification advice.
    /// </summary>
    [IsoId("_Rjuamdp-Ed-ak6NoX_4Aeg_959555509")]
    [DisplayName("Linked Agent CA Notification Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdAgtCANtfctnAdvcId")]
    #endif
    [IsoXmlTag("LkdAgtCANtfctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 LinkedAgentCANotificationAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 LinkedAgentCANotificationAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 LinkedAgentCANotificationAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 LinkedAgentCANotificationAdviceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
