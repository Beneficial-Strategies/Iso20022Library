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
/// Contains text fields in the local language.
/// </summary>
[IsoId("_BD1sscW8EeuhguwJmlgagQ")]
[DisplayName("Local Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalData5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalData5( string reqLanguage )
    {
        Language = reqLanguage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_BIoGEcW8EeuhguwJmlgagQ")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISOMax3ALanguageCode Language { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Language { get; init; } 
    #else
    public string Language { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the full name of the sponsored merchant in the local language.
    /// </summary>
    [IsoId("_BIoGE8W8EeuhguwJmlgagQ")]
    [DisplayName("Common Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonNm")]
    #endif
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max280Text)]
    [StringLength(maximumLength: 280 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax280Text? CommonName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonName { get; init; } 
    #else
    public System.String? CommonName { get; set; } 
    #endif
    
    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_3_5Z0CB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglCorpNm")]
    #endif
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? LegalCorporateName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalCorporateName { get; init; } 
    #else
    public System.String? LegalCorporateName { get; set; } 
    #endif
    
    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_BIoGKcW8EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address3? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address3? Address { get; init; } 
    #else
    public Address3? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_kaTCIMrZEeuQjLd-KKZrCg")]
    [DisplayName("Additional Address Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAdrInf")]
    #endif
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax512Text? AdditionalAddressInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalAddressInformation { get; init; } 
    #else
    public System.String? AdditionalAddressInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_s1OrEcXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
