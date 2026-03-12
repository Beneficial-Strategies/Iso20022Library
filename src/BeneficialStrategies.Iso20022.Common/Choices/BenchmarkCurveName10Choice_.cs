// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName10Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName10Choice.Name))]
    [JsonDerivedType(typeof(BenchmarkCurveName10Choice.Index),nameof(BenchmarkCurveName10Choice.Index))]
    [JsonDerivedType(typeof(BenchmarkCurveName10Choice.Name),nameof(BenchmarkCurveName10Choice.Name))]
    [IsoId("_CSXHb6x2Eem81-uIvTF5rQ")]
    [DisplayName("Benchmark Curve Name 10 Choice")]
    public abstract partial record BenchmarkCurveName10Choice_
    {
    }
}
