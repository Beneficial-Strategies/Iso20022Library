// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus10Choice.Pending))]
    [KnownType(typeof(SettlementStatus10Choice.Failing))]
    [KnownType(typeof(SettlementStatus10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus10Choice.Pending),
        nameof(SettlementStatus10Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus10Choice.Failing),
        nameof(SettlementStatus10Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus10Choice.Proprietary),
        nameof(SettlementStatus10Choice.Proprietary)
    )]
    [IsoId("_bfizof7rEeCvPoRGOxRobQ")]
    [DisplayName("Settlement Status 10 Choice")]
    public abstract record SettlementStatus10Choice_ { }
}
