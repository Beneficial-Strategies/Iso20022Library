// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the risk factor, financial instrument or set of financial instruments that is stressed under a hypothetical stress scenario.
    /// </summary>
    [KnownType(typeof(StressItem1Choice.Product))]
    [KnownType(typeof(StressItem1Choice.Strategy))]
    [KnownType(typeof(StressItem1Choice.RiskFactor))]
    [JsonDerivedType(typeof(StressItem1Choice.Product), nameof(StressItem1Choice.Product))]
    [JsonDerivedType(typeof(StressItem1Choice.Strategy), nameof(StressItem1Choice.Strategy))]
    [JsonDerivedType(typeof(StressItem1Choice.RiskFactor), nameof(StressItem1Choice.RiskFactor))]
    [IsoId("_fCpTIKsvEeayv9XxdmMwKQ")]
    [DisplayName("Stress Item 1 Choice")]
    public abstract record StressItem1Choice_ { }
}
