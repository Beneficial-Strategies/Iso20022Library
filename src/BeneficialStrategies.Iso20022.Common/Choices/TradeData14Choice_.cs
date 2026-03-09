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
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData14Choice.DataSetAction))]
    [KnownType(typeof(TradeData14Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData14Choice.DataSetAction),nameof(TradeData14Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData14Choice.Report),nameof(TradeData14Choice.Report))]
    #endif
    [IsoId("_ClNWAf_oEemm3skPVSMJQg")]
    [DisplayName("Trade Data 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData14Choice_
    #else
    public abstract partial class TradeData14Choice_
    #endif
    {
    }
}
