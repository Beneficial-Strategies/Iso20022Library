// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat23Choice
{
    /// <summary>
    /// Specifies different formats for the net dividend rate.
    /// </summary>
    [IsoId("_VmnDVWXGEeWht50_j0HXAQ")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : NetDividendRateFormat23Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_V6q_40EIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType41Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_V6q_60EIEeWVgfuHGaKtRQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_V6q_7UEIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; }
    }
}
