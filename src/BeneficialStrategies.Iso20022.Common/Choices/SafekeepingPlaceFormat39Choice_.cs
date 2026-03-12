// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Identification),nameof(SafekeepingPlaceFormat39Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Country),nameof(SafekeepingPlaceFormat39Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat39Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Proprietary),nameof(SafekeepingPlaceFormat39Choice.Proprietary))]
    [IsoId("_8GiP_ffREeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 39 Choice")]
    public abstract partial record SafekeepingPlaceFormat39Choice_
    {
    }
}
