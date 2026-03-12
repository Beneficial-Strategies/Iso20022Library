// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location on the Earth specified by two numbers representing vertical and horizontal position.
/// </summary>
[IsoId("_S4tccNj9EeiojJsa6FYyew")]
[DisplayName("Geolocation Geographic Coordinates")]
public partial record GeolocationGeographicCoordinates1
{
    #nullable enable
    
    /// <summary>
    /// Angular distance of a location on the earth south or north of the equator.
    /// The latitude is measured in degrees, minutes and seconds, following by &quot;N&quot; for the north and &quot;S&quot; for the south of the equator. For example: 48°51&apos;29&quot; N the Eiffel Tower latitude.
    /// </summary>
    [IsoId("_enk3UNj9EeiojJsa6FYyew")]
    [DisplayName("Latitude")]
    [IsoXmlTag("Lat")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Latitude { get; init; } 
    
    /// <summary>
    /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
    /// The longitude is measured in degrees, minutes and seconds, following by &quot;E&quot; for the east and &quot;W&quot; for the west. For example: 23°27&apos;30&quot; E.
    /// </summary>
    [IsoId("_o1RaYNj9EeiojJsa6FYyew")]
    [DisplayName("Longitude")]
    [IsoXmlTag("Long")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Longitude { get; init; } 
    
    
    #nullable disable
    
}
