// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat5Choice
{
    /// <summary>
    /// Specifies different formats for interest rate used for payment.
    /// </summary>
    [IsoId("_iS_3h-EREd-1Ktb5rVaajw")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public record RateTypeAndAmountAndRateStatus : InterestRateUsedForPaymentFormat5Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_UOpIt9p-Ed-ak6NoX_4Aeg_-853622525")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType6Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UOpIuNp-Ed-ak6NoX_4Aeg_-853622990")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_UOpIudp-Ed-ak6NoX_4Aeg_-853622586")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus1Choice_? RateStatus { get; init; }
    }
}
