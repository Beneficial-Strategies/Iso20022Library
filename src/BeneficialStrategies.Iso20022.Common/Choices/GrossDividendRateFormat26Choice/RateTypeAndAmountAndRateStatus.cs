// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat26Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_ctnLeZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat26Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_ckMw_ZKQEeWHWpTQn1FFVg")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType49Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_ckMxBZKQEeWHWpTQn1FFVg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_ckMxB5KQEeWHWpTQn1FFVg")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus4Choice_? RateStatus { get; init; }
    }
}
