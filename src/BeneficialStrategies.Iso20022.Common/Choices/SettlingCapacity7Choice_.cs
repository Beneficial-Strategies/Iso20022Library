// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity7Choice.Code))]
    [KnownType(typeof(SettlingCapacity7Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity7Choice.Code), nameof(SettlingCapacity7Choice.Code))]
    [JsonDerivedType(
        typeof(SettlingCapacity7Choice.Proprietary),
        nameof(SettlingCapacity7Choice.Proprietary)
    )]
    [IsoId("_cRf-ATqEEeWVrPy0StzzSg")]
    [DisplayName("Settling Capacity 7 Choice")]
    public abstract record SettlingCapacity7Choice_ { }
}
