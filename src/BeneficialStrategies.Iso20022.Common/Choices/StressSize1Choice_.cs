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
    /// Specifies the type of price move.
    /// </summary>
    [KnownType(typeof(StressSize1Choice.Relative))]
    [KnownType(typeof(StressSize1Choice.Absolute))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StressSize1Choice.Relative),nameof(StressSize1Choice.Relative))]
    [JsonDerivedType(typeof(StressSize1Choice.Absolute),nameof(StressSize1Choice.Absolute))]
    #endif
    [IsoId("_itPG0Ks1Eeayv9XxdmMwKQ")]
    [DisplayName("Stress Size 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StressSize1Choice_
    #else
    public abstract partial class StressSize1Choice_
    #endif
    {
    }
}
