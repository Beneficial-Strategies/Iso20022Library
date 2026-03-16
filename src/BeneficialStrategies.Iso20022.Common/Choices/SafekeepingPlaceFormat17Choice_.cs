// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat17Choice.Identification),
        nameof(SafekeepingPlaceFormat17Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat17Choice.Country),
        nameof(SafekeepingPlaceFormat17Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat17Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat17Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat17Choice.Proprietary),
        nameof(SafekeepingPlaceFormat17Choice.Proprietary)
    )]
    [IsoId("_cj_8gZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Format 17 Choice")]
    public abstract record SafekeepingPlaceFormat17Choice_ { }
}
