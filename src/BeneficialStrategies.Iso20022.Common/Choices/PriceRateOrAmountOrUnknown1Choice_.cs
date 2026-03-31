// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator))]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown1Choice.Rate),
        nameof(PriceRateOrAmountOrUnknown1Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown1Choice.Amount),
        nameof(PriceRateOrAmountOrUnknown1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator),
        nameof(PriceRateOrAmountOrUnknown1Choice.UnknownIndicator)
    )]
    [IsoId("_Wiwga9p-Ed-ak6NoX_4Aeg_246765395")]
    [DisplayName("Price Rate Or Amount Or Unknown 1 Choice")]
    public abstract record PriceRateOrAmountOrUnknown1Choice_ { }
}
