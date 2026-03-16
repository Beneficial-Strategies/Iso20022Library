// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat32Choice.Identification),
        nameof(SafekeepingPlaceFormat32Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat32Choice.Country),
        nameof(SafekeepingPlaceFormat32Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat32Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat32Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat32Choice.Proprietary),
        nameof(SafekeepingPlaceFormat32Choice.Proprietary)
    )]
    [IsoId("__2YuD_fDEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 32 Choice")]
    public abstract record SafekeepingPlaceFormat32Choice_ { }
}
