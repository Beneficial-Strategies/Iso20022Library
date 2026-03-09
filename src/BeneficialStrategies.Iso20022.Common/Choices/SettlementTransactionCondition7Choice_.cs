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
    [KnownType(typeof(SettlementTransactionCondition7Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTransactionCondition7Choice.Code),nameof(SettlementTransactionCondition7Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition7Choice.Proprietary),nameof(SettlementTransactionCondition7Choice.Proprietary))]
    #endif
    [IsoId("_EQSYV_IwEd-dOvqmSLSz5g")]
    [DisplayName("Settlement Transaction Condition 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition7Choice_
    #else
    public abstract partial class SettlementTransactionCondition7Choice_
    #endif
    {
    }
}
