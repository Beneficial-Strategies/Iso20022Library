// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator))]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknownChoice.Rate),
        nameof(PriceRateOrAmountOrUnknownChoice.Rate)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknownChoice.Amount),
        nameof(PriceRateOrAmountOrUnknownChoice.Amount)
    )]
    [JsonDerivedType(
        typeof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator),
        nameof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator)
    )]
    [IsoId("_QaaCFNp-Ed-ak6NoX_4Aeg_974375674")]
    [DisplayName("Price Rate Or Amount Or Unknown Choice")]
    public abstract record PriceRateOrAmountOrUnknownChoice_ { }
}
