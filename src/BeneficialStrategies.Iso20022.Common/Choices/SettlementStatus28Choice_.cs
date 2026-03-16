// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus28Choice.Pending))]
    [KnownType(typeof(SettlementStatus28Choice.Failing))]
    [KnownType(typeof(SettlementStatus28Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus28Choice.Pending),
        nameof(SettlementStatus28Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus28Choice.Failing),
        nameof(SettlementStatus28Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus28Choice.Proprietary),
        nameof(SettlementStatus28Choice.Proprietary)
    )]
    [IsoId("_BH0PmQpIEeup4r-PFG2T5Q")]
    [DisplayName("Settlement Status 28 Choice")]
    public abstract record SettlementStatus28Choice_ { }
}
