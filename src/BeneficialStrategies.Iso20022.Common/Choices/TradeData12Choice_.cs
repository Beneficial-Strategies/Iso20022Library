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
    [KnownType(typeof(TradeData12Choice.DataSetAction))]
    [KnownType(typeof(TradeData12Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData12Choice.DataSetAction),nameof(TradeData12Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData12Choice.Report),nameof(TradeData12Choice.Report))]
    #endif
    [IsoId("_SLQaof_kEemm3skPVSMJQg")]
    [DisplayName("Trade Data 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData12Choice_
    #else
    public abstract partial class TradeData12Choice_
    #endif
    {
    }
}
