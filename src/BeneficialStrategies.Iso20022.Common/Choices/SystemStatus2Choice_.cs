// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    [KnownType(typeof(SystemStatus2Choice.Code))]
    [KnownType(typeof(SystemStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemStatus2Choice.Code), nameof(SystemStatus2Choice.Code))]
    [JsonDerivedType(
        typeof(SystemStatus2Choice.Proprietary),
        nameof(SystemStatus2Choice.Proprietary)
    )]
    [IsoId("_yUPGYRbpEeOy-PlRuFSUzQ")]
    [DisplayName("System Status 2 Choice")]
    public abstract record SystemStatus2Choice_ { }
}
