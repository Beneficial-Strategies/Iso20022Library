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
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName6Choice.ISIN))]
    [KnownType(typeof(BenchmarkCurveName6Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName6Choice.Name))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.ISIN),nameof(BenchmarkCurveName6Choice.ISIN))]
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.Index),nameof(BenchmarkCurveName6Choice.Index))]
    [JsonDerivedType(typeof(BenchmarkCurveName6Choice.Name),nameof(BenchmarkCurveName6Choice.Name))]
    #endif
    [IsoId("_ZHdRcSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Benchmark Curve Name 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkCurveName6Choice_
    #else
    public abstract partial class BenchmarkCurveName6Choice_
    #endif
    {
    }
}
