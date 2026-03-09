// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Benchmark report by the relevant national institution. The report can be either an update or a cancellation.
    /// </summary>
    [KnownType(typeof(BenchmarkReport1Choice.Create))]
    [KnownType(typeof(BenchmarkReport1Choice.Update))]
    [KnownType(typeof(BenchmarkReport1Choice.Cancellation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Create),nameof(BenchmarkReport1Choice.Create))]
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Update),nameof(BenchmarkReport1Choice.Update))]
    [JsonDerivedType(typeof(BenchmarkReport1Choice.Cancellation),nameof(BenchmarkReport1Choice.Cancellation))]
    #endif
    [IsoId("_P2VfczrWEeedCZZ8dIPp6g")]
    [DisplayName("Benchmark Report 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkReport1Choice_
    #else
    public abstract partial class BenchmarkReport1Choice_
    #endif
    {
    }
}
