// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName4Choice.ISIN))]
    [KnownType(typeof(BenchmarkCurveName4Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName4Choice.Name))]
    [JsonDerivedType(
        typeof(BenchmarkCurveName4Choice.ISIN),
        nameof(BenchmarkCurveName4Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(BenchmarkCurveName4Choice.Index),
        nameof(BenchmarkCurveName4Choice.Index)
    )]
    [JsonDerivedType(
        typeof(BenchmarkCurveName4Choice.Name),
        nameof(BenchmarkCurveName4Choice.Name)
    )]
    [IsoId("_1oxvgQnVEeWa7rBfPECYsw")]
    [DisplayName("Benchmark Curve Name 4 Choice")]
    public abstract record BenchmarkCurveName4Choice_ { }
}
