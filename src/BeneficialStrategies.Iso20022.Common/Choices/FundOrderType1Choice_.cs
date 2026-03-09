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
    /// Choice of formats for the specification of the fund order type.
    /// </summary>
    [KnownType(typeof(FundOrderType1Choice.Type))]
    [KnownType(typeof(FundOrderType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundOrderType1Choice.Type),nameof(FundOrderType1Choice.Type))]
    [JsonDerivedType(typeof(FundOrderType1Choice.Proprietary),nameof(FundOrderType1Choice.Proprietary))]
    #endif
    [IsoId("_RC8V8RHcEeKVqeHljBM1MQ")]
    [DisplayName("Fund Order Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundOrderType1Choice_
    #else
    public abstract partial class FundOrderType1Choice_
    #endif
    {
    }
}
