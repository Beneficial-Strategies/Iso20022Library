// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Identification),nameof(SafekeepingPlaceFormat11Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Country),nameof(SafekeepingPlaceFormat11Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat11Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Proprietary),nameof(SafekeepingPlaceFormat11Choice.Proprietary))]
    [IsoId("_cdRpWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Format 11 Choice")]
    public abstract partial record SafekeepingPlaceFormat11Choice_
    {
    }
}
