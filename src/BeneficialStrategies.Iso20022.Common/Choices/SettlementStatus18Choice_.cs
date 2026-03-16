// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus18Choice.Pending))]
    [KnownType(typeof(SettlementStatus18Choice.Failing))]
    [KnownType(typeof(SettlementStatus18Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus18Choice.Pending),
        nameof(SettlementStatus18Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus18Choice.Failing),
        nameof(SettlementStatus18Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus18Choice.Proprietary),
        nameof(SettlementStatus18Choice.Proprietary)
    )]
    [IsoId("_17yBUTp4EeWVrPy0StzzSg")]
    [DisplayName("Settlement Status 18 Choice")]
    public abstract record SettlementStatus18Choice_ { }
}
