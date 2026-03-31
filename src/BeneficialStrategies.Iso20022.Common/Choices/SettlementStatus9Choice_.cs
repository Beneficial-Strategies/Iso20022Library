// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus9Choice.Pending))]
    [KnownType(typeof(SettlementStatus9Choice.Failing))]
    [KnownType(typeof(SettlementStatus9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus9Choice.Pending),
        nameof(SettlementStatus9Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus9Choice.Failing),
        nameof(SettlementStatus9Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus9Choice.Proprietary),
        nameof(SettlementStatus9Choice.Proprietary)
    )]
    [IsoId("_mz-M8f41EeClUvPNHKL9Zw")]
    [DisplayName("Settlement Status 9 Choice")]
    public abstract record SettlementStatus9Choice_ { }
}
