// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem3Choice.Code))]
    [KnownType(typeof(CashSettlementSystem3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CashSettlementSystem3Choice.Code),
        nameof(CashSettlementSystem3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CashSettlementSystem3Choice.Proprietary),
        nameof(CashSettlementSystem3Choice.Proprietary)
    )]
    [IsoId("_Aav3xNokEeC60axPepSq7g_1739194464")]
    [DisplayName("Cash Settlement System 3 Choice")]
    public abstract record CashSettlementSystem3Choice_ { }
}
