// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountChoice.Rate))]
    [KnownType(typeof(PriceRateOrAmountChoice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmountChoice.Rate), nameof(PriceRateOrAmountChoice.Rate))]
    [JsonDerivedType(
        typeof(PriceRateOrAmountChoice.Amount),
        nameof(PriceRateOrAmountChoice.Amount)
    )]
    [IsoId("_QaaCGNp-Ed-ak6NoX_4Aeg_-1974423999")]
    [DisplayName("Price Rate Or Amount Choice")]
    public abstract record PriceRateOrAmountChoice_ { }
}
