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
/// Alternate identification for a party using an id type, a country code and an text field.
/// </summary>
[IsoId("_PHNIUNooEeCWg-hsBVGrDA_-33380345")]
[DisplayName("Alternate Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternatePartyIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternatePartyIdentification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternatePartyIdentification6( IdentificationType41Choice_ reqTypeOfIdentification,string reqCountry,System.String reqAlternateIdentification )
    {
        TypeOfIdentification = reqTypeOfIdentification;
        Country = reqCountry;
        AlternateIdentification = reqAlternateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
    /// </summary>
    [IsoId("_PHNIUdooEeCWg-hsBVGrDA_-147219411")]
    [DisplayName("Type Of Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfId")]
    #endif
    [IsoXmlTag("TpOfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationType41Choice_ TypeOfIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationType41Choice_ TypeOfIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationType41Choice_ TypeOfIdentification { get; init; } 
    #else
    public IdentificationType41Choice_ TypeOfIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_PHNIUtooEeCWg-hsBVGrDA_-1030452698")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PHNIU9ooEeCWg-hsBVGrDA_-1144291764")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AlternateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AlternateIdentification { get; init; } 
    #else
    public System.String AlternateIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
