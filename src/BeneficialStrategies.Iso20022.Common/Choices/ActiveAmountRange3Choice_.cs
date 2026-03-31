// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a range of amount values with or without the currency.
    /// </summary>
    [KnownType(typeof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange))]
    [KnownType(typeof(ActiveAmountRange3Choice.CurrencyAndAmountRange))]
    [JsonDerivedType(
        typeof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange),
        nameof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange)
    )]
    [JsonDerivedType(
        typeof(ActiveAmountRange3Choice.CurrencyAndAmountRange),
        nameof(ActiveAmountRange3Choice.CurrencyAndAmountRange)
    )]
    [IsoId("_OnGKkZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Active Amount Range 3 Choice")]
    public abstract record ActiveAmountRange3Choice_ { }
}
