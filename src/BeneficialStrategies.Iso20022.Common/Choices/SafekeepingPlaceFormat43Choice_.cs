// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format43Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat43Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat43Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat43Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat43Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat43Choice.Country),
        nameof(SafekeepingPlaceFormat43Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat43Choice.Identification),
        nameof(SafekeepingPlaceFormat43Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat43Choice.Proprietary),
        nameof(SafekeepingPlaceFormat43Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat43Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat43Choice.TypeAndIdentification)
    )]
    [IsoId("_BNtV8ZIQEe-HRNGM304Vlw")]
    [DisplayName("Safekeeping Place Format43Choice")]
    public abstract record SafekeepingPlaceFormat43Choice_ { }
}
