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
    [KnownType(typeof(TradeReport6Choice.New))]
    [KnownType(typeof(TradeReport6Choice.Error))]
    [KnownType(typeof(TradeReport6Choice.Correction))]
    [KnownType(typeof(TradeReport6Choice.TradeUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReport6Choice.New),nameof(TradeReport6Choice.New))]
    [JsonDerivedType(typeof(TradeReport6Choice.Error),nameof(TradeReport6Choice.Error))]
    [JsonDerivedType(typeof(TradeReport6Choice.Correction),nameof(TradeReport6Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport6Choice.TradeUpdate),nameof(TradeReport6Choice.TradeUpdate))]
    #endif
    [IsoId("_QNfwAa07EemojPqsRBB5Lg")]
    [DisplayName("Trade Report 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport6Choice_
    #else
    public abstract partial class TradeReport6Choice_
    #endif
    {
    }
}
