// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat3Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_Qa2uA9p-Ed-ak6NoX_4Aeg_-696146039")]
    [DisplayName("Amount")]
    public record Amount : PriceFormat3Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QbAfANp-Ed-ak6NoX_4Aeg_-167828504")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QbAfAdp-Ed-ak6NoX_4Aeg_-140122918")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
    }
}
