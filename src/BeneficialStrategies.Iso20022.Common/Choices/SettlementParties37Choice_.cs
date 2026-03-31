// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Parties37Choice.
    /// </summary>
    [KnownType(typeof(SettlementParties37Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties37Choice.ReceivingSettlementParties))]
    [JsonDerivedType(
        typeof(SettlementParties37Choice.DeliveringSettlementParties),
        nameof(SettlementParties37Choice.DeliveringSettlementParties)
    )]
    [JsonDerivedType(
        typeof(SettlementParties37Choice.ReceivingSettlementParties),
        nameof(SettlementParties37Choice.ReceivingSettlementParties)
    )]
    [IsoId("_276Ld5IOEe-HRNGM304Vlw")]
    [DisplayName("Settlement Parties37Choice")]
    public abstract record SettlementParties37Choice_ { }
}
