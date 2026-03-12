// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName5Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName5Choice.Name))]
    [JsonDerivedType(typeof(BenchmarkCurveName5Choice.Index),nameof(BenchmarkCurveName5Choice.Index))]
    [JsonDerivedType(typeof(BenchmarkCurveName5Choice.Name),nameof(BenchmarkCurveName5Choice.Name))]
    [IsoId("_9weFgSrpEeWiy6-TnRWhpA")]
    [DisplayName("Benchmark Curve Name 5 Choice")]
    public abstract partial record BenchmarkCurveName5Choice_
    {
    }
}
