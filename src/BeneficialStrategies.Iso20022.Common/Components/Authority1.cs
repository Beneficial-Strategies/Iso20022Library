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
/// Information about the authority entity.
/// </summary>
[IsoId("_th7UgKd4EeuEcqP2FGAFaA")]
[DisplayName("Authority")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Authority1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Country code of the authority.
    /// </summary>
    [IsoId("_75G1cKd4EeuEcqP2FGAFaA")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Code that identifies a major subdivision of a country, for instance state, province.
    /// </summary>
    [IsoId("_PpdlEKd6EeuEcqP2FGAFaA")]
    [DisplayName("Country Sub Division Major")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMjr")]
    #endif
    [IsoXmlTag("CtrySubDvsnMjr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOCountrySubDivisionCode? CountrySubDivisionMajor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountrySubDivisionMajor { get; init; } 
    #else
    public string? CountrySubDivisionMajor { get; set; } 
    #endif
    
    /// <summary>
    /// Code that identifies a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_l9njoKd6EeuEcqP2FGAFaA")]
    [DisplayName("Country Sub Division Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMnr")]
    #endif
    [IsoXmlTag("CtrySubDvsnMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOCountrySubDivisionCode? CountrySubDivisionMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountrySubDivisionMinor { get; init; } 
    #else
    public string? CountrySubDivisionMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a major subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_y8RfYBvOEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Major Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMjrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? CountrySubDivisionMajorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMajorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMajorName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_sdTQ0BvOEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Minor Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMnrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? CountrySubDivisionMinorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMinorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMinorName { get; set; } 
    #endif
    
    /// <summary>
    /// City name
    /// </summary>
    [IsoId("_4LtrwKd6EeuEcqP2FGAFaA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    
    #nullable disable
    
}
