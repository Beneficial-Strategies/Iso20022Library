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
/// Specifies linkage information of a corporate action message.
/// </summary>
[IsoId("_RjH9pNp-Ed-ak6NoX_4Aeg_866442593")]
[DisplayName("Linked Corporate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LinkedCorporateAction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LinkedCorporateAction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LinkedCorporateAction1( CorporateActionNotificationType1Code reqNotificationType )
    {
        NotificationType = reqNotificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The function of the notification e.g. new notification.
    /// </summary>
    [IsoId("_RjH9pdp-Ed-ak6NoX_4Aeg_-1179382200")]
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
    /// The identification of the linked notification advice.
    /// </summary>
    [IsoId("_RjH9ptp-Ed-ak6NoX_4Aeg_883990379")]
    [DisplayName("Linked Agent CA Notification Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdAgtCANtfctnAdvcId")]
    #endif
    [IsoXmlTag("LkdAgtCANtfctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? LinkedAgentCANotificationAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? LinkedAgentCANotificationAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8? LinkedAgentCANotificationAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when the instruction is to be executed relative to a linked instruction.
    /// </summary>
    [IsoId("_RjRuoNp-Ed-ak6NoX_4Aeg_907077517")]
    [DisplayName("Linkage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkgTp")]
    #endif
    [IsoXmlTag("LkgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition2FormatChoice_? LinkageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition2FormatChoice_? LinkageType { get; init; } 
    #else
    public ProcessingPosition2FormatChoice_? LinkageType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference given to the linked event by the CA event issuer (agent).
    /// </summary>
    [IsoId("_RjRuodp-Ed-ak6NoX_4Aeg_-1520860145")]
    [DisplayName("Linked Issuer Corporate Action Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdIssrCorpActnId")]
    #endif
    [IsoXmlTag("LkdIssrCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LinkedIssuerCorporateActionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkedIssuerCorporateActionIdentification { get; init; } 
    #else
    public System.String? LinkedIssuerCorporateActionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the CSD to the linked coporate avent.
    /// </summary>
    [IsoId("_RjRuotp-Ed-ak6NoX_4Aeg_-1520860114")]
    [DisplayName("Linked Corporate Action Processing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdCorpActnPrcgId")]
    #endif
    [IsoXmlTag("LkdCorpActnPrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LinkedCorporateActionProcessingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkedCorporateActionProcessingIdentification { get; init; } 
    #else
    public System.String? LinkedCorporateActionProcessingIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
