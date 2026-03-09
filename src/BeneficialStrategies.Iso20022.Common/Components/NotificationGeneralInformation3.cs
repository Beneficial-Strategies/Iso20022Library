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
/// Event notification type and status.
/// </summary>
[IsoId("_DRyj4RrgEeyhRdHRjakS2w")]
[DisplayName("Notification General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotificationGeneralInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NotificationGeneralInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotificationGeneralInformation3( NotificationType3Code reqNotificationType,EventStatus1 reqNotificationStatus )
    {
        NotificationType = reqNotificationType;
        NotificationStatus = reqNotificationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_DujYYRrgEeyhRdHRjakS2w")]
    [DisplayName("Notification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnTp")]
    #endif
    [IsoXmlTag("NtfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationType3Code NotificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationType3Code NotificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationType3Code NotificationType { get; init; } 
    #else
    public NotificationType3Code NotificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the details of the event.
    /// </summary>
    [IsoId("_DujYaRrgEeyhRdHRjakS2w")]
    [DisplayName("Notification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnSts")]
    #endif
    [IsoXmlTag("NtfctnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventStatus1 NotificationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventStatus1 NotificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventStatus1 NotificationStatus { get; init; } 
    #else
    public EventStatus1 NotificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_DujYcRrgEeyhRdHRjakS2w")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrRghtsDrctvInd")]
    #endif
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShareholderRightsDirectiveIndicator { get; init; } 
    #else
    public System.String? ShareholderRightsDirectiveIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a specific confirmation of holding together with a participation and/or vote instruction is required by the issuer (for instance as required in the German Stock Corporation Act paragraph 67c section 3).
    /// </summary>
    [IsoId("_Pj09QBrgEeyhRdHRjakS2w")]
    [DisplayName("Confirmation Of Holding Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfOfHldgReqrd")]
    #endif
    [IsoXmlTag("ConfOfHldgReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConfirmationOfHoldingRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmationOfHoldingRequired { get; init; } 
    #else
    public System.String? ConfirmationOfHoldingRequired { get; set; } 
    #endif
    
    
    #nullable disable
    
}
