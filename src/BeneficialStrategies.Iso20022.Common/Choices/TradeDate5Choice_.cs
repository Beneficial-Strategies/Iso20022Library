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
    [KnownType(typeof(TradeDate5Choice.Date))]
    [KnownType(typeof(TradeDate5Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate5Choice.Date),nameof(TradeDate5Choice.Date))]
    [JsonDerivedType(typeof(TradeDate5Choice.DateCode),nameof(TradeDate5Choice.DateCode))]
    #endif
    [IsoId("_GxkNgTqLEeWVrPy0StzzSg")]
    [DisplayName("Trade Date 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate5Choice_
    #else
    public abstract partial class TradeDate5Choice_
    #endif
    {
    }
}
