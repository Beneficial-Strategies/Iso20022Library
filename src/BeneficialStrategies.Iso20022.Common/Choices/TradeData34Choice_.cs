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
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData34Choice.DataSetAction))]
    [KnownType(typeof(TradeData34Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData34Choice.DataSetAction),nameof(TradeData34Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData34Choice.Report),nameof(TradeData34Choice.Report))]
    #endif
    [IsoId("_Ap4T0cK3EeuFNp8LZAnorg")]
    [DisplayName("Trade Data 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData34Choice_
    #else
    public abstract partial class TradeData34Choice_
    #endif
    {
    }
}
