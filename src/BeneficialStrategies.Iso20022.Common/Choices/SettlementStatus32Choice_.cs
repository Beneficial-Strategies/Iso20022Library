// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Status32Choice.
    /// </summary>
    [KnownType(typeof(SettlementStatus32Choice.Failing))]
    [KnownType(typeof(SettlementStatus32Choice.Pending))]
    [KnownType(typeof(SettlementStatus32Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus32Choice.Failing),nameof(SettlementStatus32Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus32Choice.Pending),nameof(SettlementStatus32Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus32Choice.Proprietary),nameof(SettlementStatus32Choice.Proprietary))]
    [IsoId("_xhBo94cSEe-U27oWwgmhCQ")]
    [DisplayName("Settlement Status32Choice")]
    public abstract partial record SettlementStatus32Choice_
    {
    }
}
