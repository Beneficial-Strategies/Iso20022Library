// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity8Choice.Code))]
    [KnownType(typeof(SettlingCapacity8Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity8Choice.Code), nameof(SettlingCapacity8Choice.Code))]
    [JsonDerivedType(
        typeof(SettlingCapacity8Choice.Proprietary),
        nameof(SettlingCapacity8Choice.Proprietary)
    )]
    [IsoId("_5m5aiZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settling Capacity 8 Choice")]
    public abstract record SettlingCapacity8Choice_ { }
}
