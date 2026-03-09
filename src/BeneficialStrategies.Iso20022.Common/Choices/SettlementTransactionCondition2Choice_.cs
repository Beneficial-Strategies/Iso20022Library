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
    [KnownType(typeof(SettlementTransactionCondition2Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTransactionCondition2Choice.Code),nameof(SettlementTransactionCondition2Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition2Choice.Proprietary),nameof(SettlementTransactionCondition2Choice.Proprietary))]
    #endif
    [IsoId("_QuYG89p-Ed-ak6NoX_4Aeg_-450512718")]
    [DisplayName("Settlement Transaction Condition 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition2Choice_
    #else
    public abstract partial class SettlementTransactionCondition2Choice_
    #endif
    {
    }
}
