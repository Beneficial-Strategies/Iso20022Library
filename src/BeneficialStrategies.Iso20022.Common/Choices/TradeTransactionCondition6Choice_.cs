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
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition6Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeTransactionCondition6Choice.Code),nameof(TradeTransactionCondition6Choice.Code))]
    [JsonDerivedType(typeof(TradeTransactionCondition6Choice.Proprietary),nameof(TradeTransactionCondition6Choice.Proprietary))]
    #endif
    [IsoId("_5msltZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Transaction Condition 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeTransactionCondition6Choice_
    #else
    public abstract partial class TradeTransactionCondition6Choice_
    #endif
    {
    }
}
