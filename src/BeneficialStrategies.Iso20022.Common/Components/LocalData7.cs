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
[IsoId("_bTHMccrfEeuQjLd-KKZrCg")]
[DisplayName("Local Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalData7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalData7( string reqLanguage )
    {
        Language = reqLanguage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_bY980crfEeuQjLd-KKZrCg")]
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
    /// Name of the cardholder in the local language.
    /// </summary>
    [IsoId("_bY9808rfEeuQjLd-KKZrCg")]
    [DisplayName("Cardholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrNm")]
    #endif
    [IsoXmlTag("CrdhldrNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName2? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName2? CardholderName { get; init; } 
    #else
    public CardholderName2? CardholderName { get; set; } 
    #endif
    
    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_bY981crfEeuQjLd-KKZrCg")]
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
    /// Additional local language data
    /// </summary>
    [IsoId("_bY9818rfEeuQjLd-KKZrCg")]
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
