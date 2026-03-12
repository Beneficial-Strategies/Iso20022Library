// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName6Choice.ISIN))]
    [KnownType(typeof(BenchmarkCurveName6Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName6Choice.Name))]
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.ISIN),nameof(BenchmarkCurveName6Choice.ISIN))]
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.Index),nameof(BenchmarkCurveName6Choice.Index))]
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.Name),nameof(BenchmarkCurveName6Choice.Name))]
    [IsoId("_ZHdRcSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Benchmark Curve Name 6 Choice")]
    public abstract partial record BenchmarkCurveName6Choice_
    {
    }
}
