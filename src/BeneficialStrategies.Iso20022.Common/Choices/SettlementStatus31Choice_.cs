// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus31Choice.Pending))]
    [KnownType(typeof(SettlementStatus31Choice.Failing))]
    [KnownType(typeof(SettlementStatus31Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus31Choice.Pending),
        nameof(SettlementStatus31Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus31Choice.Failing),
        nameof(SettlementStatus31Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus31Choice.Proprietary),
        nameof(SettlementStatus31Choice.Proprietary)
    )]
    [IsoId("_f99L9Ti8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Status 31 Choice")]
    public abstract record SettlementStatus31Choice_ { }
}
