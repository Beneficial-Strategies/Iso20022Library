// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat46Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_b3eOJUELEeWVgfuHGaKtRQ")]
    [DisplayName("Amount Price")]
    [IsoXmlTag("AmtPric")]
    public record AmountPrice : PriceFormat46Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QaHHI9p-Ed-ak6NoX_4Aeg_141257751")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType2Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QaHHJNp-Ed-ak6NoX_4Aeg_94966020")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
    }
}
