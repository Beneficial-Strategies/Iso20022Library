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
/// Corporate action event notification status and contents.
/// </summary>
[IsoId("_se-jkSXZEeOFIcNWlDEvdQ")]
[DisplayName("Corporate Action Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotification4( CorporateActionNotificationType1Code reqNotificationType,CorporateActionProcessingStatus4Choice_ reqProcessingStatus )
    {
        NotificationType = reqNotificationType;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of notification.
    /// </summary>
    [IsoId("_s2rR4yXZEeOFIcNWlDEvdQ")]
    [DisplayName("Notification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnTp")]
    #endif
    [IsoXmlTag("NtfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionNotificationType1Code NotificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationType1Code NotificationType { get; init; } 
    #else
    public CorporateActionNotificationType1Code NotificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [IsoId("_s2rR6yXZEeOFIcNWlDEvdQ")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionProcessingStatus4Choice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionProcessingStatus4Choice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionProcessingStatus4Choice_ ProcessingStatus { get; init; } 
    #else
    public CorporateActionProcessingStatus4Choice_ ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the eligible balance is final except for a voluntary corporate action event where it can represent the current eligible balance when communicated before expiration date of that event.
    /// </summary>
    [IsoId("_s2rR8yXZEeOFIcNWlDEvdQ")]
    [DisplayName("Eligible Balance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblBalInd")]
    #endif
    [IsoXmlTag("ElgblBalInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibleBalanceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleBalanceIndicator { get; init; } 
    #else
    public System.String? EligibleBalanceIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
