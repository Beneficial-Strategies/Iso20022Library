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
/// Identify the original notification and to provide the status.
/// </summary>
[IsoId("_1E2M0Bf2Ed--ta5221d4PQ")]
[DisplayName("Original Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalNotification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalNotification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalNotification3( System.String reqOriginalMessageIdentification,System.String reqOriginalNotificationIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        OriginalNotificationIdentification = reqOriginalNotificationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_1FcpwRf2Ed--ta5221d4PQ")]
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
    [IsoId("_1FlzsRf2Ed--ta5221d4PQ")]
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
    [IsoId("_1Fvkshf2Ed--ta5221d4PQ")]
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
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("_1GVakxf2Ed--ta5221d4PQ")]
    [DisplayName("Notification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnSts")]
    #endif
    [IsoXmlTag("NtfctnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    #else
    public NotificationStatus3Code? NotificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("_1GyGgRf2Ed--ta5221d4PQ")]
    [DisplayName("Additional Status Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStsInf")]
    #endif
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatusInformation { get; init; } 
    #else
    public System.String? AdditionalStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("_1HFoghf2Ed--ta5221d4PQ")]
    [DisplayName("Original Notification Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNtfctnRef")]
    #endif
    [IsoXmlTag("OrgnlNtfctnRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalNotificationReference2? OriginalNotificationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalNotificationReference2? OriginalNotificationReference { get; init; } 
    #else
    public OriginalNotificationReference2? OriginalNotificationReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
