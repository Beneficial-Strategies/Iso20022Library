// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus7Choice.Pending))]
    [KnownType(typeof(SettlementStatus7Choice.Failing))]
    [KnownType(typeof(SettlementStatus7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus7Choice.Pending),
        nameof(SettlementStatus7Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus7Choice.Failing),
        nameof(SettlementStatus7Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus7Choice.Proprietary),
        nameof(SettlementStatus7Choice.Proprietary)
    )]
    [IsoId("_Bsv4If40EeClUvPNHKL9Zw")]
    [DisplayName("Settlement Status 7 Choice")]
    public abstract record SettlementStatus7Choice_ { }
}
