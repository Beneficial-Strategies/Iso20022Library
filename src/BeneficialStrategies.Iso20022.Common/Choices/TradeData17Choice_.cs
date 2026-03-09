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
    /// Position/transaction reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(TradeData17Choice.DataSetAction))]
    [KnownType(typeof(TradeData17Choice.Report))]
    [KnownType(typeof(TradeData17Choice.State))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData17Choice.DataSetAction),nameof(TradeData17Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData17Choice.Report),nameof(TradeData17Choice.Report))]
    [JsonDerivedType(typeof(TradeData17Choice.State),nameof(TradeData17Choice.State))]
    #endif
    [IsoId("_bN4vcRLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Data 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData17Choice_
    #else
    public abstract partial class TradeData17Choice_
    #endif
    {
    }
}
