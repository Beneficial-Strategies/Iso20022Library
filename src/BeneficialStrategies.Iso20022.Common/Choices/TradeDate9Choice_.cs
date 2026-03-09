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
    [KnownType(typeof(TradeDate9Choice.Date))]
    [KnownType(typeof(TradeDate9Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate9Choice.Date),nameof(TradeDate9Choice.Date))]
    [JsonDerivedType(typeof(TradeDate9Choice.DateCode),nameof(TradeDate9Choice.DateCode))]
    #endif
    [IsoId("_qImeCc3yEee5nJBZsW8MFQ")]
    [DisplayName("Trade Date 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate9Choice_
    #else
    public abstract partial class TradeDate9Choice_
    #endif
    {
    }
}
