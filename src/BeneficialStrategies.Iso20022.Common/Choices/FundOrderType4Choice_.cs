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
    /// Choice of formats for the order type.
    /// </summary>
    [KnownType(typeof(FundOrderType4Choice.Code))]
    [KnownType(typeof(FundOrderType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundOrderType4Choice.Code),nameof(FundOrderType4Choice.Code))]
    [JsonDerivedType(typeof(FundOrderType4Choice.Proprietary),nameof(FundOrderType4Choice.Proprietary))]
    #endif
    [IsoId("_EYsKEThREeaRwdGFv45qTQ")]
    [DisplayName("Fund Order Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundOrderType4Choice_
    #else
    public abstract partial class FundOrderType4Choice_
    #endif
    {
    }
}
