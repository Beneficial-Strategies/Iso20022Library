// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName7Choice.Code))]
    [KnownType(typeof(BenchmarkCurveName7Choice.Proprietary))]
    [JsonDerivedType(typeof(BenchmarkCurveName7Choice.Code),nameof(BenchmarkCurveName7Choice.Code))]
    [JsonDerivedType(typeof(BenchmarkCurveName7Choice.Proprietary),nameof(BenchmarkCurveName7Choice.Proprietary))]
    [IsoId("_HZotkeLwEeWOD7aAy2fAcA")]
    [DisplayName("Benchmark Curve Name 7 Choice")]
    public abstract partial record BenchmarkCurveName7Choice_
    {
    }
}
