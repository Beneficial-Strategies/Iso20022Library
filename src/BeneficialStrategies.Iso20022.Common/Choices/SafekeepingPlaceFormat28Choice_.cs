// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Identification),nameof(SafekeepingPlaceFormat28Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Country),nameof(SafekeepingPlaceFormat28Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat28Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Proprietary),nameof(SafekeepingPlaceFormat28Choice.Proprietary))]
    [IsoId("_oTwbEWpXEeipaMTLlhaKMQ")]
    [DisplayName("Safekeeping Place Format 28 Choice")]
    public abstract partial record SafekeepingPlaceFormat28Choice_
    {
    }
}
