// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of price move.
    /// </summary>
    [KnownType(typeof(StressSize1Choice.Relative))]
    [KnownType(typeof(StressSize1Choice.Absolute))]
    [JsonDerivedType(typeof(StressSize1Choice.Relative),nameof(StressSize1Choice.Relative))]
    [JsonDerivedType(typeof(StressSize1Choice.Absolute),nameof(StressSize1Choice.Absolute))]
    [IsoId("_itPG0Ks1Eeayv9XxdmMwKQ")]
    [DisplayName("Stress Size 1 Choice")]
    public abstract partial record StressSize1Choice_
    {
    }
}
