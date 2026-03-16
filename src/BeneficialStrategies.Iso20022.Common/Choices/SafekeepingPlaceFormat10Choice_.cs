// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat10Choice.Identification),
        nameof(SafekeepingPlaceFormat10Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat10Choice.Country),
        nameof(SafekeepingPlaceFormat10Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat10Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat10Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat10Choice.Proprietary),
        nameof(SafekeepingPlaceFormat10Choice.Proprietary)
    )]
    [IsoId("_43Qi8TnTEeWV5sr121Fc8A")]
    [DisplayName("Safekeeping Place Format 10 Choice")]
    public abstract record SafekeepingPlaceFormat10Choice_ { }
}
