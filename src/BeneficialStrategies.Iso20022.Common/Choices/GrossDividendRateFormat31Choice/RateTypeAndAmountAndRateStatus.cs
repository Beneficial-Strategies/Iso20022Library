// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat31Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_skrJT83wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat31Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_skrJac3wEee5nJBZsW8MFQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType72Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_skrJcc3wEee5nJBZsW8MFQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_skrJc83wEee5nJBZsW8MFQ")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus4Choice_? RateStatus { get; init; }
    }
}
