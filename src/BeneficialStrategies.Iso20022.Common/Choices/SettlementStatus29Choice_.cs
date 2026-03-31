// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus29Choice.Pending))]
    [KnownType(typeof(SettlementStatus29Choice.Failing))]
    [KnownType(typeof(SettlementStatus29Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus29Choice.Pending),
        nameof(SettlementStatus29Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus29Choice.Failing),
        nameof(SettlementStatus29Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus29Choice.Proprietary),
        nameof(SettlementStatus29Choice.Proprietary)
    )]
    [IsoId("_qTHeGSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Status 29 Choice")]
    public abstract record SettlementStatus29Choice_ { }
}
