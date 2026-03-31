// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties7Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties7Choice.ReceivingSettlementParties))]
    [JsonDerivedType(
        typeof(SettlementParties7Choice.DeliveringSettlementParties),
        nameof(SettlementParties7Choice.DeliveringSettlementParties)
    )]
    [JsonDerivedType(
        typeof(SettlementParties7Choice.ReceivingSettlementParties),
        nameof(SettlementParties7Choice.ReceivingSettlementParties)
    )]
    [IsoId("_tQ_Rl4pIEeaNTaanBSMWmg")]
    [DisplayName("Settlement Parties 7 Choice")]
    public abstract record SettlementParties7Choice_ { }
}
