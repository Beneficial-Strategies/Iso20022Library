// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat59Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_ctkvC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Amount Price")]
    [IsoXmlTag("AmtPric")]
    public record AmountPrice : PriceFormat59Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_Wi6RZtp-Ed-ak6NoX_4Aeg_259535984")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_Wi6RZ9p-Ed-ak6NoX_4Aeg_-1734608722")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
    }
}
