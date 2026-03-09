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
/// Provides information about event of a corporate action.
/// </summary>
[IsoId("_doLKvZwuEeazcsnODTksnQ")]
[DisplayName("Event Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventInformation10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventInformation10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventInformation10( System.String reqCorporateActionEventIdentification,CorporateActionEventType58Choice_ reqEventType,CorporateActionMandatoryVoluntary4Choice_ reqMandatoryVoluntaryEventType )
    {
        CorporateActionEventIdentification = reqCorporateActionEventIdentification;
        EventType = reqEventType;
        MandatoryVoluntaryEventType = reqMandatoryVoluntaryEventType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_doLKv5wuEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CorporateActionEventIdentification { get; init; } 
    #else
    public System.String CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference of the linked official corporate action event.
    /// </summary>
    [IsoId("_doLKx5wuEeazcsnODTksnQ")]
    [DisplayName("Official Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclCorpActnEvtId")]
    #endif
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfficialCorporateActionEventIdentification { get; init; } 
    #else
    public System.String? OfficialCorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_doLKz5wuEeazcsnODTksnQ")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType58Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType58Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType58Choice_ EventType { get; init; } 
    #else
    public CorporateActionEventType58Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_doLK15wuEeazcsnODTksnQ")]
    [DisplayName("Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("MndtryVlntryEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the identification of the last notification.
    /// </summary>
    [IsoId("_doLK35wuEeazcsnODTksnQ")]
    [DisplayName("Last Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastNtfctnId")]
    #endif
    [IsoXmlTag("LastNtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotificationIdentification4? LastNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationIdentification4? LastNotificationIdentification { get; init; } 
    #else
    public NotificationIdentification4? LastNotificationIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
