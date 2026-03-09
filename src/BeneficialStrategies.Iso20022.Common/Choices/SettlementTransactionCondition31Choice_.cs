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
    [KnownType(typeof(SettlementTransactionCondition31Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition31Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTransactionCondition31Choice.Code),nameof(SettlementTransactionCondition31Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition31Choice.Proprietary),nameof(SettlementTransactionCondition31Choice.Proprietary))]
    #endif
    [IsoId("_sWKeMZCBEeakHoV5BVecAQ")]
    [DisplayName("Settlement Transaction Condition 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition31Choice_
    #else
    public abstract partial class SettlementTransactionCondition31Choice_
    #endif
    {
    }
}
