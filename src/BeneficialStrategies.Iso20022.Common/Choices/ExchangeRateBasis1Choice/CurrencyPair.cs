// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateBasis1Choice
{
    /// <summary>
    /// Exchange rate basis expressed as a currency pair.
    /// </summary>
    [IsoId("_PV2OYLpqEea_jI1vMH_RbA")]
    [DisplayName("Currency Pair")]
    [IsoXmlTag("CcyPair")]
    public record CurrencyPair : ExchangeRateBasis1Choice_
    {
        /// <summary>
        /// Currency in which the rate of exchange is expressed in a currency exchange.
        /// Usage: In the example one GBP equals xxxUSD, the unit currency is GBP.
        /// </summary>
        [IsoId("_ui8blg3WEeW9YKj3GUmIEw")]
        [DisplayName("Base Currency")]
        [IsoXmlTag("BaseCcy")]
        public required ActiveCurrencyCode BaseCurrency { get; init; }

        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_ui8bng3WEeW9YKj3GUmIEw")]
        [DisplayName("Quoted Currency")]
        [IsoXmlTag("QtdCcy")]
        public required ActiveCurrencyCode QuotedCurrency { get; init; }
    }
}
