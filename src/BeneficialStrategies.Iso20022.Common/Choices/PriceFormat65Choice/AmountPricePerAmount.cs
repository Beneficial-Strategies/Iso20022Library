// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat65Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per amount.
    /// </summary>
    [IsoId("_MVDy4xuyEeyhRdHRjakS2w")]
    [DisplayName("Amount Price Per Amount")]
    public record AmountPricePerAmount : PriceFormat65Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QaHHJtp-Ed-ak6NoX_4Aeg_-219272751")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QaHHJ9p-Ed-ak6NoX_4Aeg_-219272726")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

        /// <summary>
        /// The amount on which the price is based.
        /// </summary>
        [IsoId("_QaHHKNp-Ed-ak6NoX_4Aeg_-219272709")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }
    }
}
