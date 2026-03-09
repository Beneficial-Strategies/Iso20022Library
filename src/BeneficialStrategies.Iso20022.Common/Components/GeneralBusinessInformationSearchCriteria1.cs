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
/// Defines the criteria used to search for business information.
/// </summary>
[IsoId("_51l8cZlZEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Information Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralBusinessInformationSearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous reference assigned to a general business information system.
    /// </summary>
    [IsoId("_59y2MZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
    /// </summary>
    [IsoId("_59y2M5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sbjt")]
    #endif
    [IsoXmlTag("Sbjt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CharacterSearch1Choice_? Subject { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CharacterSearch1Choice_? Subject { get; init; } 
    #else
    public CharacterSearch1Choice_? Subject { get; set; } 
    #endif
    
    /// <summary>
    /// Further information about the criticality or importance of a general business information system.
    /// </summary>
    [IsoId("_59y2NZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qlfr")]
    #endif
    [IsoXmlTag("Qlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InformationQualifierType1? Qualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationQualifierType1? Qualifier { get; init; } 
    #else
    public InformationQualifierType1? Qualifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
