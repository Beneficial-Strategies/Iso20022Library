// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat53Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per amount.
    /// </summary>
    [IsoId("_che0k5KQEeWHWpTQn1FFVg")]
    [DisplayName("Amount Price Per Amount")]
    public record AmountPricePerAmount : PriceFormat53Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_WjDbV9p-Ed-ak6NoX_4Aeg_1859334423")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_WjDbWNp-Ed-ak6NoX_4Aeg_16214062")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

        /// <summary>
        /// The amount on which the price is based.
        /// </summary>
        [IsoId("_WjDbWdp-Ed-ak6NoX_4Aeg_-1977930644")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }
    }
}
