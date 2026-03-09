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
    [KnownType(typeof(BenchmarkCurveName10Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName10Choice.Name))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BenchmarkCurveName10Choice.Index),nameof(BenchmarkCurveName10Choice.Index))]
    [JsonDerivedType(typeof(BenchmarkCurveName10Choice.Name),nameof(BenchmarkCurveName10Choice.Name))]
    #endif
    [IsoId("_CSXHb6x2Eem81-uIvTF5rQ")]
    [DisplayName("Benchmark Curve Name 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkCurveName10Choice_
    #else
    public abstract partial class BenchmarkCurveName10Choice_
    #endif
    {
    }
}
