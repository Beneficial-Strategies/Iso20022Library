// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard index code or proprietary code to specify a rate Index type.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName13Choice.Code))]
    [KnownType(typeof(BenchmarkCurveName13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BenchmarkCurveName13Choice.Code),
        nameof(BenchmarkCurveName13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BenchmarkCurveName13Choice.Proprietary),
        nameof(BenchmarkCurveName13Choice.Proprietary)
    )]
    [IsoId("_g9r0ERIkEeyLzJfz3xPQNA")]
    [DisplayName("Benchmark Curve Name 13 Choice")]
    public abstract record BenchmarkCurveName13Choice_ { }
}
