// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Identification),nameof(SafekeepingPlaceFormat3Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Country),nameof(SafekeepingPlaceFormat3Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat3Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Proprietary),nameof(SafekeepingPlaceFormat3Choice.Proprietary))]
    [IsoId("_SfeRKdp-Ed-ak6NoX_4Aeg_-955186669")]
    [DisplayName("Safekeeping Place Format 3 Choice")]
    public abstract partial record SafekeepingPlaceFormat3Choice_
    {
    }
}
