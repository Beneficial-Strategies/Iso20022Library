// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Identification),nameof(SafekeepingPlaceFormat27Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Country),nameof(SafekeepingPlaceFormat27Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat27Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Proprietary),nameof(SafekeepingPlaceFormat27Choice.Proprietary))]
    [IsoId("_k1xAAaWXEeahOrvW2rewGg")]
    [DisplayName("Safekeeping Place Format 27 Choice")]
    public abstract partial record SafekeepingPlaceFormat27Choice_
    {
    }
}
