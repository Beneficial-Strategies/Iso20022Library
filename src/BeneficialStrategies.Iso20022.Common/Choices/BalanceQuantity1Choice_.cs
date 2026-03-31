// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity1Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity1Choice.QuantityAsDSS))]
    [JsonDerivedType(
        typeof(BalanceQuantity1Choice.Quantity),
        nameof(BalanceQuantity1Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity1Choice.QuantityAsDSS),
        nameof(BalanceQuantity1Choice.QuantityAsDSS)
    )]
    [IsoId("_RCDQ59p-Ed-ak6NoX_4Aeg_695361822")]
    [DisplayName("Balance Quantity 1 Choice")]
    public abstract record BalanceQuantity1Choice_ { }
}
