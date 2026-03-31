// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat5Choice
{
    /// <summary>
    /// Specifies different formats for the tax credit rate.
    /// </summary>
    [IsoId("_DeFVI-wPEd-sn-FiNtktcA")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    [IsoXmlTag("RateTpAndAmtAndRateSts")]
    public record RateTypeAndAmountAndRateStatus : TaxCreditRateFormat5Choice_
    {
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_UOVmttp-Ed-ak6NoX_4Aeg_1556183180")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType10Choice_ RateType { get; init; }

        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UOVmt9p-Ed-ak6NoX_4Aeg_1556182558")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_UOVmuNp-Ed-ak6NoX_4Aeg_1556182747")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus1Choice_? RateStatus { get; init; }
    }
}
