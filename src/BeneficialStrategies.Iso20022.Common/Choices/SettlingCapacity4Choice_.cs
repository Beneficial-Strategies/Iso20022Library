// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity4Choice.Code))]
    [KnownType(typeof(SettlingCapacity4Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity4Choice.Code), nameof(SettlingCapacity4Choice.Code))]
    [JsonDerivedType(
        typeof(SettlingCapacity4Choice.Proprietary),
        nameof(SettlingCapacity4Choice.Proprietary)
    )]
    [IsoId("_m6SEYSW3EeOslcz0TJwprQ")]
    [DisplayName("Settling Capacity 4 Choice")]
    public abstract record SettlingCapacity4Choice_ { }
}
