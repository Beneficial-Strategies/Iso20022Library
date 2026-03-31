// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat37Choice
{
    /// <summary>
    /// Specifies different formats for the net dividend rate.
    /// </summary>
    [IsoId("_OiLqB-XsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : NetDividendRateFormat37Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_OzSoIeXsEemEj48jhmlA0Q")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType77Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_OzSoKeXsEemEj48jhmlA0Q")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_OzSoK-XsEemEj48jhmlA0Q")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; }
    }
}
