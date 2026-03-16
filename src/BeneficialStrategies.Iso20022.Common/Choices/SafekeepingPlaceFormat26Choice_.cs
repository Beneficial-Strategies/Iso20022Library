// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat26Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat26Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat26Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat26Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat26Choice.Identification),
        nameof(SafekeepingPlaceFormat26Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat26Choice.Country),
        nameof(SafekeepingPlaceFormat26Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat26Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat26Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat26Choice.Proprietary),
        nameof(SafekeepingPlaceFormat26Choice.Proprietary)
    )]
    [IsoId("_Vyh4_5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Safekeeping Place Format 26 Choice")]
    public abstract record SafekeepingPlaceFormat26Choice_ { }
}
