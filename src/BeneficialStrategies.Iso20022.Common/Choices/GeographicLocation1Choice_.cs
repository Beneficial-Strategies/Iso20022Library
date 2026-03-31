// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Geographic location of the ATM specified by geographic coordinates or UTM coordinates.
    /// </summary>
    [KnownType(typeof(GeographicLocation1Choice.GeographicCoordinates))]
    [KnownType(typeof(GeographicLocation1Choice.UTMCoordinates))]
    [JsonDerivedType(
        typeof(GeographicLocation1Choice.GeographicCoordinates),
        nameof(GeographicLocation1Choice.GeographicCoordinates)
    )]
    [JsonDerivedType(
        typeof(GeographicLocation1Choice.UTMCoordinates),
        nameof(GeographicLocation1Choice.UTMCoordinates)
    )]
    [IsoId("_4klZMIn4EeShMpas3885ww")]
    [DisplayName("Geographic Location 1 Choice")]
    public abstract record GeographicLocation1Choice_ { }
}
