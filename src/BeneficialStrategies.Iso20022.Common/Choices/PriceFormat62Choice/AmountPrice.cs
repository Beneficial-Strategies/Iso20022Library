// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat62Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_5M7N49BXEee0mNiKMkpGNQ")]
    [DisplayName("Amount Price")]
    [IsoXmlTag("AmtPric")]
    public record AmountPrice : PriceFormat62Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_I__eAdBYEee0mNiKMkpGNQ")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType3Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_I__eCdBYEee0mNiKMkpGNQ")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
    }
}
