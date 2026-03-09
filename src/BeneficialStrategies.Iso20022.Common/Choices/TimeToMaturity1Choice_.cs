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
    /// Provides the options for the time to maturity.
    /// </summary>
    [KnownType(typeof(TimeToMaturity1Choice.Period))]
    [KnownType(typeof(TimeToMaturity1Choice.Special))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeToMaturity1Choice.Period),nameof(TimeToMaturity1Choice.Period))]
    [JsonDerivedType(typeof(TimeToMaturity1Choice.Special),nameof(TimeToMaturity1Choice.Special))]
    #endif
    [IsoId("_r8FOkMVaEeiYpLQka876sg")]
    [DisplayName("Time To Maturity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeToMaturity1Choice_
    #else
    public abstract partial class TimeToMaturity1Choice_
    #endif
    {
    }
}
