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
    [KnownType(typeof(SettlementTransactionCondition30Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition30Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTransactionCondition30Choice.Code),nameof(SettlementTransactionCondition30Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition30Choice.Proprietary),nameof(SettlementTransactionCondition30Choice.Proprietary))]
    #endif
    [IsoId("_1VRycUc8EeaBWtcfqEyXyw")]
    [DisplayName("Settlement Transaction Condition 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition30Choice_
    #else
    public abstract partial class SettlementTransactionCondition30Choice_
    #endif
    {
    }
}
