// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat9Choice
{
    /// <summary>
    /// Specifies different formats for interest rate used for payment.
    /// </summary>
    [IsoId("_cj-HC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public record RateTypeAndAmountAndRateStatus : InterestRateUsedForPaymentFormat9Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_cj-HGZKQEeWHWpTQn1FFVg")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType45Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_cj-HIZKQEeWHWpTQn1FFVg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_cj-HI5KQEeWHWpTQn1FFVg")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus4Choice_? RateStatus { get; init; }
    }
}
