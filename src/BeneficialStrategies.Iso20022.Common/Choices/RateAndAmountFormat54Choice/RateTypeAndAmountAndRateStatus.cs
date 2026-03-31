// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat54Choice
{
    /// <summary>
    /// Value is expressed as a rate type and an amount.
    /// </summary>
    [IsoId("_Tmj9e9EDEeetfps_dpxRmg")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : RateAndAmountFormat54Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_T5IDYdBbEee0mNiKMkpGNQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required DeemedRateType2Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_T5IDadBbEee0mNiKMkpGNQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_T5IDa9BbEee0mNiKMkpGNQ")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus4Choice_? RateStatus { get; init; }
    }
}
