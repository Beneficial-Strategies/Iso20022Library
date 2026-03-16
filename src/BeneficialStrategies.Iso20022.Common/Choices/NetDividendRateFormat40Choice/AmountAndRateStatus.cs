// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat40Choice
{
    /// <summary>
    /// Specifies an amount and a rate status.
    /// </summary>
    [IsoId("_jASs8-XsEemEj48jhmlA0Q")]
    [DisplayName("Amount And Rate Status")]
    public record AmountAndRateStatus : NetDividendRateFormat40Choice_
    {
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_gx2YoGOVEeWYYI9c62RCjw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_j8yDkGOVEeWYYI9c62RCjw")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public required RateStatus1Code RateStatus { get; init; }
    }
}
