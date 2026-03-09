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
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate6Choice.Date))]
    [KnownType(typeof(TradeDate6Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate6Choice.Date),nameof(TradeDate6Choice.Date))]
    [JsonDerivedType(typeof(TradeDate6Choice.DateCode),nameof(TradeDate6Choice.DateCode))]
    #endif
    [IsoId("_5TGUWZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Date 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate6Choice_
    #else
    public abstract partial class TradeDate6Choice_
    #endif
    {
    }
}
