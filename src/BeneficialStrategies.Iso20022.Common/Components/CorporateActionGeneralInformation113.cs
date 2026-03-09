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
/// General information about the corporate action event.
/// </summary>
[IsoId("_sb-5iZwqEeazcsnODTksnQ")]
[DisplayName("Corporate Action General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformation113
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionGeneralInformation113 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionGeneralInformation113( System.String reqCorporateActionEventIdentification,CorporateActionEventType57Choice_ reqEventType,CorporateActionMandatoryVoluntary4Choice_ reqMandatoryVoluntaryEventType,FinancialInstrumentAttributes85 reqUnderlyingSecurity )
    {
        CorporateActionEventIdentification = reqCorporateActionEventIdentification;
        EventType = reqEventType;
        MandatoryVoluntaryEventType = reqMandatoryVoluntaryEventType;
        UnderlyingSecurity = reqUnderlyingSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_sb-5j5wqEeazcsnODTksnQ")]
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
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_sb-5l5wqEeazcsnODTksnQ")]
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
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_sb-5n5wqEeazcsnODTksnQ")]
    [DisplayName("Class Action Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssActnNb")]
    #endif
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassActionNumber { get; init; } 
    #else
    public System.String? ClassActionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [IsoId("_sb-5p5wqEeazcsnODTksnQ")]
    [DisplayName("Event Processing Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrcgTp")]
    #endif
    [IsoXmlTag("EvtPrcgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; } 
    #else
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_sb-5r5wqEeazcsnODTksnQ")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType57Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType57Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType57Choice_ EventType { get; init; } 
    #else
    public CorporateActionEventType57Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_sb-5t5wqEeazcsnODTksnQ")]
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
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_sb-5v5wqEeazcsnODTksnQ")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentAttributes85 UnderlyingSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentAttributes85 UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes85 UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributes85 UnderlyingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
