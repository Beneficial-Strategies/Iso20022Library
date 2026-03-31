// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location on the Earth specified by the Universal Transverse Mercator coordinate system.
/// Identifies the geographic location using the WGS84 ellipsoid spatial reference system.
/// </summary>
[IsoId("_IRYb8Nj-EeiojJsa6FYyew")]
[DisplayName("Geolocation UTM Coordinates")]
public record GeolocationUTMCoordinates1
{
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band (C to X, excluding I and O).
    /// </summary>
    [IsoId("_S03o0Nj-EeiojJsa6FYyew")]
    [DisplayName("UTM Zone")]
    [IsoXmlTag("UTMZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text UTMZone { get; init; }

    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator
    /// coordinate system.
    /// </summary>
    [IsoId("_bxdJUNj-EeiojJsa6FYyew")]
    [DisplayName("UTM Eastward")]
    [IsoXmlTag("UTMEstwrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text UTMEastward { get; init; }

    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator
    /// coordinate system.
    /// </summary>
    [IsoId("_iqNJ0Nj-EeiojJsa6FYyew")]
    [DisplayName("UTM Northward")]
    [IsoXmlTag("UTMNrthwrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text UTMNorthward { get; init; }
}
