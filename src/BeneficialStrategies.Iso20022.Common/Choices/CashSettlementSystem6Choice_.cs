// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem6Choice.Code))]
    [KnownType(typeof(CashSettlementSystem6Choice.Proprietary))]
    [JsonDerivedType(typeof(CashSettlementSystem6Choice.Code), nameof(CashSettlementSystem6Choice.Code))]
    [JsonDerivedType(typeof(CashSettlementSystem6Choice.Proprietary), nameof(CashSettlementSystem6Choice.Proprietary))]
    [IsoId("_etEcMZZ1EfC2_67yGLymgA")]
    [DisplayName("CashSettlementSystem6Choice")]
    public abstract record CashSettlementSystem6Choice_ { }
}
