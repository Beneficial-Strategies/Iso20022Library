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
    /// Choice of formats for a time horizon.
    /// </summary>
    [KnownType(typeof(TimeHorizon1Choice.NumberOfYears))]
    [KnownType(typeof(TimeHorizon1Choice.TimeFrame))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeHorizon1Choice.NumberOfYears),nameof(TimeHorizon1Choice.NumberOfYears))]
    [JsonDerivedType(typeof(TimeHorizon1Choice.TimeFrame),nameof(TimeHorizon1Choice.TimeFrame))]
    #endif
    [IsoId("_t5CX0DcuEeidBoT_PugKiA")]
    [DisplayName("Time Horizon 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeHorizon1Choice_
    #else
    public abstract partial class TimeHorizon1Choice_
    #endif
    {
    }
}
