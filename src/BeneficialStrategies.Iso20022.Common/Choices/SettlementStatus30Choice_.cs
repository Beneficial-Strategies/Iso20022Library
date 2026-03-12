// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus30Choice.Pending))]
    [KnownType(typeof(SettlementStatus30Choice.Failing))]
    [KnownType(typeof(SettlementStatus30Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus30Choice.Pending),nameof(SettlementStatus30Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus30Choice.Failing),nameof(SettlementStatus30Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus30Choice.Proprietary),nameof(SettlementStatus30Choice.Proprietary))]
    [IsoId("_coFnuSW-EeygjNFjAlVoPA")]
    [DisplayName("Settlement Status 30 Choice")]
    public abstract partial record SettlementStatus30Choice_
    {
    }
}
