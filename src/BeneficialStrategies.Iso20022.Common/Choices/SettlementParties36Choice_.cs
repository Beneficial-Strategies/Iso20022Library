// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties36Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties36Choice.ReceivingSettlementParties))]
    [JsonDerivedType(
        typeof(SettlementParties36Choice.DeliveringSettlementParties),
        nameof(SettlementParties36Choice.DeliveringSettlementParties)
    )]
    [JsonDerivedType(
        typeof(SettlementParties36Choice.ReceivingSettlementParties),
        nameof(SettlementParties36Choice.ReceivingSettlementParties)
    )]
    [IsoId("_Vx2Q9yqSEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Parties 36 Choice")]
    public abstract record SettlementParties36Choice_ { }
}
