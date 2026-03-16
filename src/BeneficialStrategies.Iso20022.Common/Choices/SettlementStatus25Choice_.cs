// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus25Choice.Code))]
    [KnownType(typeof(SettlementStatus25Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus25Choice.Code), nameof(SettlementStatus25Choice.Code))]
    [JsonDerivedType(
        typeof(SettlementStatus25Choice.Proprietary),
        nameof(SettlementStatus25Choice.Proprietary)
    )]
    [IsoId("_8QcPsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status 25 Choice")]
    public abstract record SettlementStatus25Choice_ { }
}
