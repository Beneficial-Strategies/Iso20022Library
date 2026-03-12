// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Identification),nameof(SafekeepingPlaceFormat29Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Country),nameof(SafekeepingPlaceFormat29Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat29Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Proprietary),nameof(SafekeepingPlaceFormat29Choice.Proprietary))]
    [IsoId("_XZQIObXEEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Place Format 29 Choice")]
    public abstract partial record SafekeepingPlaceFormat29Choice_
    {
    }
}
