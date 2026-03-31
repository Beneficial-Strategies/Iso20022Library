// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat58Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_ctku1ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount Price")]
    [IsoXmlTag("AmtPric")]
    public record AmountPrice : PriceFormat58Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_Wiwgadp-Ed-ak6NoX_4Aeg_1480556892")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType2Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_Wiwgatp-Ed-ak6NoX_4Aeg_-436549113")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
    }
}
