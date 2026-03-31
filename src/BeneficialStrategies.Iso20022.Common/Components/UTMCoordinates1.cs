// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location on the Earth specified by the Universal Transverse Mercator coordinate system, using the WGS84 geodesic system.
/// </summary>
[IsoId("_wETkwIn5EeShMpas3885ww")]
[DisplayName("UTM Coordinates")]
public record UTMCoordinates1
{
    /// <summary>
    /// UTM grid zone combination of the longitude zone (1 to 60) and the latitude band, C to X, excluding I and O (for example Eiffel tower UTM zone is 31U).
    /// </summary>
    [IsoId("_4AW1UIn5EeShMpas3885ww")]
    [DisplayName("UTM Zone")]
    [IsoXmlTag("UTMZone")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text UTMZone { get; init; }

    /// <summary>
    /// X-coordinate of the Universal Transverse Mercator coordinate system in meters (for example 448 265m for Eiffel Tower X-coordinate).
    /// </summary>
    [IsoId("_7o5CQIn5EeShMpas3885ww")]
    [DisplayName("UTM Eastward")]
    [IsoXmlTag("UTMEstwrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber UTMEastward { get; init; }

    /// <summary>
    /// Y-coordinate of the Universal Transverse Mercator coordinate system (for example 5 411 920m for Eiffel Tower Y-coordinate).
    /// </summary>
    [IsoId("_--JG0In5EeShMpas3885ww")]
    [DisplayName("UTM Northward")]
    [IsoXmlTag("UTMNrthwrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber UTMNorthward { get; init; }
}
