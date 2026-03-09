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
    [KnownType(typeof(BenchmarkCurveName7Choice.Code))]
    [KnownType(typeof(BenchmarkCurveName7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BenchmarkCurveName7Choice.Code),nameof(BenchmarkCurveName7Choice.Code))]
    [JsonDerivedType(typeof(BenchmarkCurveName7Choice.Proprietary),nameof(BenchmarkCurveName7Choice.Proprietary))]
    #endif
    [IsoId("_HZotkeLwEeWOD7aAy2fAcA")]
    [DisplayName("Benchmark Curve Name 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkCurveName7Choice_
    #else
    public abstract partial class BenchmarkCurveName7Choice_
    #endif
    {
    }
}
