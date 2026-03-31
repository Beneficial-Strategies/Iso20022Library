// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat7Choice.Identification),
        nameof(SafekeepingPlaceFormat7Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat7Choice.Country),
        nameof(SafekeepingPlaceFormat7Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat7Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat7Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat7Choice.Proprietary),
        nameof(SafekeepingPlaceFormat7Choice.Proprietary)
    )]
    [IsoId("_Ww2fMS7CEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Place Format 7 Choice")]
    public abstract record SafekeepingPlaceFormat7Choice_ { }
}
