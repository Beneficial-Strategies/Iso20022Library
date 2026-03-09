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
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport21Choice.New))]
    [KnownType(typeof(TradeReport21Choice.Error))]
    [KnownType(typeof(TradeReport21Choice.Correction))]
    [KnownType(typeof(TradeReport21Choice.TradeUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReport21Choice.New),nameof(TradeReport21Choice.New))]
    [JsonDerivedType(typeof(TradeReport21Choice.Error),nameof(TradeReport21Choice.Error))]
    [JsonDerivedType(typeof(TradeReport21Choice.Correction),nameof(TradeReport21Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport21Choice.TradeUpdate),nameof(TradeReport21Choice.TradeUpdate))]
    #endif
    [IsoId("_SJHcgcg2EeuGrNSsxk3B0A")]
    [DisplayName("Trade Report 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport21Choice_
    #else
    public abstract partial class TradeReport21Choice_
    #endif
    {
    }
}
