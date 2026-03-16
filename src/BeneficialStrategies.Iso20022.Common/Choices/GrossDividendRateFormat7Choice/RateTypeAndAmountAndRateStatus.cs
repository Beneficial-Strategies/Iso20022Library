// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat7Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_nZ98dxFaEeKp2ZN13DI_pA")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat7Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_mvWSFRFaEeKp2ZN13DI_pA")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType20Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_mvWSHxFaEeKp2ZN13DI_pA")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_mvWSIxFaEeKp2ZN13DI_pA")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus1Choice_? RateStatus { get; init; }
    }
}
