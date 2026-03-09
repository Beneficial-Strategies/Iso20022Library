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
/// Provides addtional information such as the taxation conditions.
/// </summary>
[IsoId("_UMQjFNp-Ed-ak6NoX_4Aeg_1627158994")]
[DisplayName("Corporate Action Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides conditional information related to the event, eg, an offer is subject to 50% acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_UMQjFdp-Ed-ak6NoX_4Aeg_1455730205")]
    [DisplayName("Information Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfConds")]
    #endif
    [IsoXmlTag("InfConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InformationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InformationConditions { get; init; } 
    #else
    public System.String? InformationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, eg, not open to US/Canadian residents, QIB or SIL to be provided.
    /// </summary>
    [IsoId("_UMQjFtp-Ed-ak6NoX_4Aeg_1926725018")]
    [DisplayName("Information To Comply With")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfToCmplyWth")]
    #endif
    [IsoXmlTag("InfToCmplyWth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InformationToComplyWith { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InformationToComplyWith { get; init; } 
    #else
    public System.String? InformationToComplyWith { get; set; } 
    #endif
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message.
    /// </summary>
    [IsoId("_UMQjF9p-Ed-ak6NoX_4Aeg_1559163291")]
    [DisplayName("Taxation Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnConds")]
    #endif
    [IsoXmlTag("TaxtnConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? TaxationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxationConditions { get; init; } 
    #else
    public System.String? TaxationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provide the new name of a company following a name change.
    /// </summary>
    [IsoId("_UMQjGNp-Ed-ak6NoX_4Aeg_-1855110380")]
    [DisplayName("New Company Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewCpnyNm")]
    #endif
    [IsoXmlTag("NewCpnyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? NewCompanyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewCompanyName { get; init; } 
    #else
    public System.String? NewCompanyName { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_UMQjGdp-Ed-ak6NoX_4Aeg_-1823711037")]
    [DisplayName("Offeror")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Offerr")]
    #endif
    [IsoXmlTag("Offerr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? Offeror { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? Offeror { get; init; } 
    #else
    public PartyIdentification2Choice_? Offeror { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the web address published for the event, ie the address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_UMQjGtp-Ed-ak6NoX_4Aeg_-1784925026")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a|message.
    /// </summary>
    [IsoId("_UMZtANp-Ed-ak6NoX_4Aeg_-1766454729")]
    [DisplayName("Additional Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxt")]
    #endif
    [IsoXmlTag("AddtlTxt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalText { get; init; } 
    #else
    public System.String? AdditionalText { get; set; } 
    #endif
    
    
    #nullable disable
    
}
