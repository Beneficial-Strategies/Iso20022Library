// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Calculation Agent1Choice.
    /// </summary>
    [KnownType(typeof(CalculationAgent1Choice.Code))]
    [KnownType(typeof(CalculationAgent1Choice.Proprietary))]
    [JsonDerivedType(typeof(CalculationAgent1Choice.Code), nameof(CalculationAgent1Choice.Code))]
    [JsonDerivedType(
        typeof(CalculationAgent1Choice.Proprietary),
        nameof(CalculationAgent1Choice.Proprietary)
    )]
    [IsoId("_16JIcEj8Ee-KhcStGV4xTg")]
    [DisplayName("Calculation Agent1Choice")]
    public abstract record CalculationAgent1Choice_ { }
}
