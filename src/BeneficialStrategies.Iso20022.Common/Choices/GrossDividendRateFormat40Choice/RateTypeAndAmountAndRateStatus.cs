// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat40Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_-lv7SwVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat40Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_-lv7ZQVSEeqjd8n6wD9JVw")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType82Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_-lv7bQVSEeqjd8n6wD9JVw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_-lv7bwVSEeqjd8n6wD9JVw")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus4Choice_? RateStatus { get; init; }
    }
}
