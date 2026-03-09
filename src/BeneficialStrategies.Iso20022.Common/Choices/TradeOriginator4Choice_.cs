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
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator4Choice.Code))]
    [KnownType(typeof(TradeOriginator4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeOriginator4Choice.Code),nameof(TradeOriginator4Choice.Code))]
    [JsonDerivedType(typeof(TradeOriginator4Choice.Proprietary),nameof(TradeOriginator4Choice.Proprietary))]
    #endif
    [IsoId("_5mtMh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Originator 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeOriginator4Choice_
    #else
    public abstract partial class TradeOriginator4Choice_
    #endif
    {
    }
}
