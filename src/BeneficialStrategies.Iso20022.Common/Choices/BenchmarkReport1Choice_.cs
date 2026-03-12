// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Benchmark report by the relevant national institution. The report can be either an update or a cancellation.
    /// </summary>
    [KnownType(typeof(BenchmarkReport1Choice.Create))]
    [KnownType(typeof(BenchmarkReport1Choice.Update))]
    [KnownType(typeof(BenchmarkReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Create),nameof(BenchmarkReport1Choice.Create))]
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Update),nameof(BenchmarkReport1Choice.Update))]
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Cancellation),nameof(BenchmarkReport1Choice.Cancellation))]
    [IsoId("_P2VfczrWEeedCZZ8dIPp6g")]
    [DisplayName("Benchmark Report 1 Choice")]
    public abstract partial record BenchmarkReport1Choice_
    {
    }
}
