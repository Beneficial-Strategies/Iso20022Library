// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown3Choice.UnknownIndicator))]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown3Choice.Rate),
        nameof(PriceRateOrAmountOrUnknown3Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown3Choice.Amount),
        nameof(PriceRateOrAmountOrUnknown3Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknown3Choice.UnknownIndicator),
        nameof(PriceRateOrAmountOrUnknown3Choice.UnknownIndicator)
    )]
    [IsoId("_gdOxl833Eee5nJBZsW8MFQ")]
    [DisplayName("Price Rate Or Amount Or Unknown 3 Choice")]
    public abstract record PriceRateOrAmountOrUnknown3Choice_ { }
}
