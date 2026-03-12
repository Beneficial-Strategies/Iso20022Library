// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat8Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat8Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat8Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat8Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat8Choice.Identification),nameof(SafekeepingPlaceFormat8Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat8Choice.Country),nameof(SafekeepingPlaceFormat8Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat8Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat8Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat8Choice.Proprietary),nameof(SafekeepingPlaceFormat8Choice.Proprietary))]
    [IsoId("_kXdIER5iEeWDV95LUQhXCA")]
    [DisplayName("Safekeeping Place Format 8 Choice")]
    public abstract partial record SafekeepingPlaceFormat8Choice_
    {
    }
}
