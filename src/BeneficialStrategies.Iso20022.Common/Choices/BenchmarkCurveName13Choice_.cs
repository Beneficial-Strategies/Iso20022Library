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
    /// Choice between a standard index code or proprietary code to specify a rate Index type.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName13Choice.Code))]
    [KnownType(typeof(BenchmarkCurveName13Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BenchmarkCurveName13Choice.Code),nameof(BenchmarkCurveName13Choice.Code))]
    [JsonDerivedType(typeof(BenchmarkCurveName13Choice.Proprietary),nameof(BenchmarkCurveName13Choice.Proprietary))]
    #endif
    [IsoId("_g9r0ERIkEeyLzJfz3xPQNA")]
    [DisplayName("Benchmark Curve Name 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkCurveName13Choice_
    #else
    public abstract partial class BenchmarkCurveName13Choice_
    #endif
    {
    }
}
