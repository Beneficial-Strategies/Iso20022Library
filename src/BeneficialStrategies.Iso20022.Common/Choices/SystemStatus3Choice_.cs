// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    [KnownType(typeof(SystemStatus3Choice.Code))]
    [KnownType(typeof(SystemStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemStatus3Choice.Code),nameof(SystemStatus3Choice.Code))]
    [JsonDerivedType(typeof(SystemStatus3Choice.Proprietary),nameof(SystemStatus3Choice.Proprietary))]
    [IsoId("_1Y_TsYpbEeiaB-4Hjqs8aw")]
    [DisplayName("System Status 3 Choice")]
    public abstract partial record SystemStatus3Choice_
    {
    }
}
