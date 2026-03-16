// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem5Choice.Code))]
    [KnownType(typeof(CashSettlementSystem5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CashSettlementSystem5Choice.Code),
        nameof(CashSettlementSystem5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CashSettlementSystem5Choice.Proprietary),
        nameof(CashSettlementSystem5Choice.Proprietary)
    )]
    [IsoId("_5m6BBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cash Settlement System 5 Choice")]
    public abstract record CashSettlementSystem5Choice_ { }
}
