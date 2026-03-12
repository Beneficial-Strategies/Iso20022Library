// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties3Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties3Choice.ReceivingSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties3Choice.DeliveringSettlementParties),nameof(SettlementParties3Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties3Choice.ReceivingSettlementParties),nameof(SettlementParties3Choice.ReceivingSettlementParties))]
    [IsoId("__eyMsWQQEeSTN56gbbyx2g")]
    [DisplayName("Settlement Parties 3 Choice")]
    public abstract partial record SettlementParties3Choice_
    {
    }
}
