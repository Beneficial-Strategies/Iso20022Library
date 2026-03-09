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
    /// Choice of formats for an order type.
    /// </summary>
    [KnownType(typeof(FundOrderType5Choice.Code))]
    [KnownType(typeof(FundOrderType5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundOrderType5Choice.Code),nameof(FundOrderType5Choice.Code))]
    [JsonDerivedType(typeof(FundOrderType5Choice.Proprietary),nameof(FundOrderType5Choice.Proprietary))]
    #endif
    [IsoId("_IfVZwV8rEeicg40_9gK9vQ")]
    [DisplayName("Fund Order Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundOrderType5Choice_
    #else
    public abstract partial class FundOrderType5Choice_
    #endif
    {
    }
}
