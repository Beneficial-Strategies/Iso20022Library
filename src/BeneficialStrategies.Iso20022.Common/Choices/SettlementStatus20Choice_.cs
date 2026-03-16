// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus20Choice.Pending))]
    [KnownType(typeof(SettlementStatus20Choice.Failing))]
    [KnownType(typeof(SettlementStatus20Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus20Choice.Pending),
        nameof(SettlementStatus20Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus20Choice.Failing),
        nameof(SettlementStatus20Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus20Choice.Proprietary),
        nameof(SettlementStatus20Choice.Proprietary)
    )]
    [IsoId("_5SGOQ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status 20 Choice")]
    public abstract record SettlementStatus20Choice_ { }
}
