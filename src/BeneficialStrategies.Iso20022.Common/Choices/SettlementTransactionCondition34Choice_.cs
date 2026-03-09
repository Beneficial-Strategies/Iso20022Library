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
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition34Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTransactionCondition34Choice.Code),nameof(SettlementTransactionCondition34Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition34Choice.Proprietary),nameof(SettlementTransactionCondition34Choice.Proprietary))]
    #endif
    [IsoId("_U3q2uQllEeuQ1MenzX1l-g")]
    [DisplayName("Settlement Transaction Condition 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition34Choice_
    #else
    public abstract partial class SettlementTransactionCondition34Choice_
    #endif
    {
    }
}
