// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the authority entity.
/// </summary>
[IsoId("_th7UgKd4EeuEcqP2FGAFaA")]
[DisplayName("Authority")]
public partial record Authority1
{
    #nullable enable
    
    /// <summary>
    /// Country code of the authority.
    /// </summary>
    [IsoId("_75G1cKd4EeuEcqP2FGAFaA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Code that identifies a major subdivision of a country, for instance state, province.
    /// </summary>
    [IsoId("_PpdlEKd6EeuEcqP2FGAFaA")]
    [DisplayName("Country Sub Division Major")]
    [IsoXmlTag("CtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMajor { get; init; } 
    
    /// <summary>
    /// Code that identifies a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_l9njoKd6EeuEcqP2FGAFaA")]
    [DisplayName("Country Sub Division Minor")]
    [IsoXmlTag("CtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMinor { get; init; } 
    
    /// <summary>
    /// Name of a major subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_y8RfYBvOEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? CountrySubDivisionMajorName { get; init; } 
    
    /// <summary>
    /// Name of a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_sdTQ0BvOEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? CountrySubDivisionMinorName { get; init; } 
    
    /// <summary>
    /// City name
    /// </summary>
    [IsoId("_4LtrwKd6EeuEcqP2FGAFaA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? Name { get; init; } 
    
    
    #nullable disable
    
}
