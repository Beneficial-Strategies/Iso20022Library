// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat27Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_zJWMTZb7Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat27Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_zZQ3kZb7Eee8S7xwGG7Veg")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType68Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_zZQ3mZb7Eee8S7xwGG7Veg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_zZQ3m5b7Eee8S7xwGG7Veg")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; }
    }
}
