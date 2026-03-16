// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Parties38Choice.
    /// </summary>
    [KnownType(typeof(SettlementParties38Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties38Choice.ReceivingSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties38Choice.DeliveringSettlementParties),nameof(SettlementParties38Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties38Choice.ReceivingSettlementParties),nameof(SettlementParties38Choice.ReceivingSettlementParties))]
    [IsoId("_3wzzIZIOEe-HRNGM304Vlw")]
    [DisplayName("Settlement Parties38Choice")]
    public abstract partial record SettlementParties38Choice_
    {
    }
}
