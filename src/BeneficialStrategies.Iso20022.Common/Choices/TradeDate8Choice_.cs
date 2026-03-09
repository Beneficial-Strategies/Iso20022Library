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
    [KnownType(typeof(TradeDate8Choice.Date))]
    [KnownType(typeof(TradeDate8Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate8Choice.Date),nameof(TradeDate8Choice.Date))]
    [JsonDerivedType(typeof(TradeDate8Choice.DateCode),nameof(TradeDate8Choice.DateCode))]
    #endif
    [IsoId("_vej6AbPuEeelzbgsFa3sqQ")]
    [DisplayName("Trade Date 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate8Choice_
    #else
    public abstract partial class TradeDate8Choice_
    #endif
    {
    }
}
