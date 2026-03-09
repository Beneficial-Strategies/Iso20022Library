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
[IsoId("_TWwedtp-Ed-ak6NoX_4Aeg_1860440704")]
[DisplayName("Corporate Action General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionGeneralInformation4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionGeneralInformation4( System.String reqCorporateActionEventIdentification,CorporateActionEventType3Choice_ reqEventType,SecurityIdentification11 reqUnderlyingSecurityIdentification )
    {
        CorporateActionEventIdentification = reqCorporateActionEventIdentification;
        EventType = reqEventType;
        UnderlyingSecurityIdentification = reqUnderlyingSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TWwed9p-Ed-ak6NoX_4Aeg_1860440735")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
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
    [IsoId("_TWweeNp-Ed-ak6NoX_4Aeg_1860441006")]
    [DisplayName("Official Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclCorpActnEvtId")]
    #endif
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfficialCorporateActionEventIdentification { get; init; } 
    #else
    public System.String? OfficialCorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_TWweedp-Ed-ak6NoX_4Aeg_-1393576622")]
    [DisplayName("Class Action Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssActnNb")]
    #endif
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassActionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassActionNumber { get; init; } 
    #else
    public System.String? ClassActionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_TWweetp-Ed-ak6NoX_4Aeg_1860441098")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType3Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType3Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType3Choice_ EventType { get; init; } 
    #else
    public CorporateActionEventType3Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    [IsoId("_TWwee9p-Ed-ak6NoX_4Aeg_1894212721")]
    [DisplayName("Underlying Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygSctyId")]
    #endif
    [IsoXmlTag("UndrlygSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 UnderlyingSecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification11 UnderlyingSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 UnderlyingSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11 UnderlyingSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_TWwefNp-Ed-ak6NoX_4Aeg_1922315031")]
    [DisplayName("Additional Business Process Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBizPrcInd")]
    #endif
    [IsoXmlTag("AddtlBizPrcInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBusinessProcessFormat3Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBusinessProcessFormat3Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #else
    public AdditionalBusinessProcessFormat3Choice_? AdditionalBusinessProcessIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
