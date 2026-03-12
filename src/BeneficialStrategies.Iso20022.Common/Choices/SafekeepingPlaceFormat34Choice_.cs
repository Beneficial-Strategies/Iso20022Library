// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Identification),nameof(SafekeepingPlaceFormat34Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Country),nameof(SafekeepingPlaceFormat34Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat34Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Proprietary),nameof(SafekeepingPlaceFormat34Choice.Proprietary))]
    [IsoId("_9C3BB_fEEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 34 Choice")]
    public abstract partial record SafekeepingPlaceFormat34Choice_
    {
    }
}
