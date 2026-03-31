// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat18Choice
{
    /// <summary>
    /// Rate Type And Amount And Rate Status.
    /// </summary>
    [DisplayName("Rate Type And Amount And Rate Status")]
    public record RateTypeAndAmountAndRateStatus : InterestRateUsedForPaymentFormat18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RateTpAndAmtAndRateSts")]
        public required RateTypeAndAmountAndStatus32 Value { get; init; }
    }
}
