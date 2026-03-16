// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties2Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties2Choice.ReceivingSettlementParties))]
    [JsonDerivedType(
        typeof(SettlementParties2Choice.DeliveringSettlementParties),
        nameof(SettlementParties2Choice.DeliveringSettlementParties)
    )]
    [JsonDerivedType(
        typeof(SettlementParties2Choice.ReceivingSettlementParties),
        nameof(SettlementParties2Choice.ReceivingSettlementParties)
    )]
    [IsoId("_-an2laMOEeCojJW5vEuTEQ_-1750301164")]
    [DisplayName("Settlement Parties 2 Choice")]
    public abstract record SettlementParties2Choice_ { }
}
