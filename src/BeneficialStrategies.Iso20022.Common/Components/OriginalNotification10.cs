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
/// Identifies the original notification, to which the cancellation advice refers.
/// </summary>
[IsoId("_2K8qoTq4EeWZFYSPlduMhw")]
[DisplayName("Original Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalNotification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalNotification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalNotification10( System.String reqOriginalMessageIdentification,System.String reqOriginalNotificationIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        OriginalNotificationIdentification = reqOriginalNotificationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_2R6OQzq4EeWZFYSPlduMhw")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageIdentification { get; init; } 
    #else
    public System.String OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_2R6ORTq4EeWZFYSPlduMhw")]
    [DisplayName("Original Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCreDtTm")]
    #endif
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalCreationDateTime { get; init; } 
    #else
    public System.DateTime? OriginalCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_2R6ORzq4EeWZFYSPlduMhw")]
    [DisplayName("Original Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNtfctnId")]
    #endif
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalNotificationIdentification { get; init; } 
    #else
    public System.String OriginalNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cancellation applies to the complete original notification or to individual items within the original notification.
    /// </summary>
    [IsoId("_2R6OSTq4EeWZFYSPlduMhw")]
    [DisplayName("Notification Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnCxl")]
    #endif
    [IsoXmlTag("NtfctnCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoGroupCancellationIndicator? NotificationCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NotificationCancellation { get; init; } 
    #else
    public System.String? NotificationCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the original notification item, to which the cancellation advice refers.
    /// </summary>
    [IsoId("_2R6OSzq4EeWZFYSPlduMhw")]
    [DisplayName("Original Notification Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNtfctnRef")]
    #endif
    [IsoXmlTag("OrgnlNtfctnRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalNotificationReference8? OriginalNotificationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalNotificationReference8? OriginalNotificationReference { get; init; } 
    #else
    public OriginalNotificationReference8? OriginalNotificationReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
