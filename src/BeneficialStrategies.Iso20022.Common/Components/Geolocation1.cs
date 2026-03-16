// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Geographic location specified by geographic or UTM coordinates.
/// </summary>
[IsoId("_4ORaINj8EeiojJsa6FYyew")]
[DisplayName("Geolocation")]
public record Geolocation1
{
    /// <summary>
    /// Geographic location specified by geographic coordinates.
    /// </summary>
    [IsoId("_A7PU0Nj-EeiojJsa6FYyew")]
    [DisplayName("Geographic Coordinates")]
    [IsoXmlTag("GeogcCordints")]
    public GeolocationGeographicCoordinates1? GeographicCoordinates { get; init; }

    /// <summary>
    /// Geographic location specified by UTM coordinates.
    /// </summary>
    [IsoId("_wMXuUNj-EeiojJsa6FYyew")]
    [DisplayName("UTM Coordinates")]
    [IsoXmlTag("UTMCordints")]
    public GeolocationUTMCoordinates1? UTMCoordinates { get; init; }
}
