// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties5Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties5Choice.ReceivingSettlementParties))]
    [JsonDerivedType(
        typeof(SettlementParties5Choice.DeliveringSettlementParties),
        nameof(SettlementParties5Choice.DeliveringSettlementParties)
    )]
    [JsonDerivedType(
        typeof(SettlementParties5Choice.ReceivingSettlementParties),
        nameof(SettlementParties5Choice.ReceivingSettlementParties)
    )]
    [IsoId("_uU7Ll4FvEeWtPe6Crjmeug")]
    [DisplayName("Settlement Parties 5 Choice")]
    public abstract record SettlementParties5Choice_ { }
}
