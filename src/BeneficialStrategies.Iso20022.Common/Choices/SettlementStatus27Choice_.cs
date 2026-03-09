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
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [KnownType(typeof(SettlementStatus27Choice.PartialSettlement))]
    [KnownType(typeof(SettlementStatus27Choice.Settled))]
    [KnownType(typeof(SettlementStatus27Choice.Unsettled))]
    [KnownType(typeof(SettlementStatus27Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus27Choice.PartialSettlement),nameof(SettlementStatus27Choice.PartialSettlement))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Settled),nameof(SettlementStatus27Choice.Settled))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Unsettled),nameof(SettlementStatus27Choice.Unsettled))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Proprietary),nameof(SettlementStatus27Choice.Proprietary))]
    #endif
    [IsoId("_QHmxsOCbEei2UYJ62ws-Fw")]
    [DisplayName("Settlement Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus27Choice_
    #else
    public abstract partial class SettlementStatus27Choice_
    #endif
    {
    }
}
