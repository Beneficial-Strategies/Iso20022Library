// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format40Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat40Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat40Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat40Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat40Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat40Choice.Country),nameof(SafekeepingPlaceFormat40Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat40Choice.Identification),nameof(SafekeepingPlaceFormat40Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat40Choice.Proprietary),nameof(SafekeepingPlaceFormat40Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat40Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat40Choice.TypeAndIdentification))]
    [IsoId("_F281kRwREe6O0NdiBuX__w")]
    [DisplayName("Safekeeping Place Format40Choice")]
    public abstract partial record SafekeepingPlaceFormat40Choice_
    {
    }
}
