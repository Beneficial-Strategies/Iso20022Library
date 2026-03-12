// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [KnownType(typeof(SettlementStatus27Choice.PartialSettlement))]
    [KnownType(typeof(SettlementStatus27Choice.Settled))]
    [KnownType(typeof(SettlementStatus27Choice.Unsettled))]
    [KnownType(typeof(SettlementStatus27Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.PartialSettlement),nameof(SettlementStatus27Choice.PartialSettlement))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Settled),nameof(SettlementStatus27Choice.Settled))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Unsettled),nameof(SettlementStatus27Choice.Unsettled))]
    [JsonDerivedType(typeof(SettlementStatus27Choice.Proprietary),nameof(SettlementStatus27Choice.Proprietary))]
    [IsoId("_QHmxsOCbEei2UYJ62ws-Fw")]
    [DisplayName("Settlement Status 27 Choice")]
    public abstract partial record SettlementStatus27Choice_
    {
    }
}
