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
    [KnownType(typeof(TradeTransactionCondition4Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeTransactionCondition4Choice.Code),nameof(TradeTransactionCondition4Choice.Code))]
    [JsonDerivedType(typeof(TradeTransactionCondition4Choice.Proprietary),nameof(TradeTransactionCondition4Choice.Proprietary))]
    #endif
    [IsoId("_AcY2h9okEeC60axPepSq7g_-1144479083")]
    [DisplayName("Trade Transaction Condition 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeTransactionCondition4Choice_
    #else
    public abstract partial class TradeTransactionCondition4Choice_
    #endif
    {
    }
}
