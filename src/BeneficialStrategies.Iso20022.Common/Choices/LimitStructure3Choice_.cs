// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Structure3Choice.
    /// </summary>
    [KnownType(typeof(LimitStructure3Choice.AllCurrentLimits))]
    [KnownType(typeof(LimitStructure3Choice.CurrentLimitIdentification))]
    [JsonDerivedType(
        typeof(LimitStructure3Choice.AllCurrentLimits),
        nameof(LimitStructure3Choice.AllCurrentLimits)
    )]
    [JsonDerivedType(
        typeof(LimitStructure3Choice.CurrentLimitIdentification),
        nameof(LimitStructure3Choice.CurrentLimitIdentification)
    )]
    [IsoId("_64VGkTEyEe6g-ffJsqGiSA")]
    [DisplayName("Limit Structure3Choice")]
    public abstract record LimitStructure3Choice_ { }
}
