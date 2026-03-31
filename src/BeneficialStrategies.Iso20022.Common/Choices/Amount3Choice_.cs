// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount with or without the currency.
    /// </summary>
    [KnownType(typeof(Amount3Choice.AmountWithCurrency))]
    [KnownType(typeof(Amount3Choice.AmountWithoutCurrency))]
    [JsonDerivedType(
        typeof(Amount3Choice.AmountWithCurrency),
        nameof(Amount3Choice.AmountWithCurrency)
    )]
    [JsonDerivedType(
        typeof(Amount3Choice.AmountWithoutCurrency),
        nameof(Amount3Choice.AmountWithoutCurrency)
    )]
    [IsoId("_750BhaMgEeCJ6YNENx4h-w_-899399961")]
    [DisplayName("Amount 3 Choice")]
    public abstract record Amount3Choice_ { }
}
