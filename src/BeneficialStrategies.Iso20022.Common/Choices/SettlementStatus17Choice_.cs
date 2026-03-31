// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus17Choice.Pending))]
    [KnownType(typeof(SettlementStatus17Choice.Failing))]
    [KnownType(typeof(SettlementStatus17Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus17Choice.Pending),
        nameof(SettlementStatus17Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus17Choice.Failing),
        nameof(SettlementStatus17Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus17Choice.Proprietary),
        nameof(SettlementStatus17Choice.Proprietary)
    )]
    [IsoId("_z2VXwTp4EeWVrPy0StzzSg")]
    [DisplayName("Settlement Status 17 Choice")]
    public abstract record SettlementStatus17Choice_ { }
}
