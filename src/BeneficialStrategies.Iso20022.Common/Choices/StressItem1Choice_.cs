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
    /// Specifies the risk factor, financial instrument or set of financial instruments that is stressed under a hypothetical stress scenario.
    /// </summary>
    [KnownType(typeof(StressItem1Choice.Product))]
    [KnownType(typeof(StressItem1Choice.Strategy))]
    [KnownType(typeof(StressItem1Choice.RiskFactor))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StressItem1Choice.Product),nameof(StressItem1Choice.Product))]
    [JsonDerivedType(typeof(StressItem1Choice.Strategy),nameof(StressItem1Choice.Strategy))]
    [JsonDerivedType(typeof(StressItem1Choice.RiskFactor),nameof(StressItem1Choice.RiskFactor))]
    #endif
    [IsoId("_fCpTIKsvEeayv9XxdmMwKQ")]
    [DisplayName("Stress Item 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StressItem1Choice_
    #else
    public abstract partial class StressItem1Choice_
    #endif
    {
    }
}
