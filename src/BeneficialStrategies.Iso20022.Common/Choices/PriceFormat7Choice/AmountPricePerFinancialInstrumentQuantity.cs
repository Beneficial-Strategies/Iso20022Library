// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat7Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per financial instrument quantity.
    /// </summary>
    [IsoId("_Q4qEU9p-Ed-ak6NoX_4Aeg_-1885731192")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    public record AmountPricePerFinancialInstrumentQuantity : PriceFormat7Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QaQ4Idp-Ed-ak6NoX_4Aeg_539368946")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QaQ4Itp-Ed-ak6NoX_4Aeg_570765997")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_QaQ4I9p-Ed-ak6NoX_4Aeg_-1521602945")]
        [DisplayName("Financial Instrument Quantity")]
        [IsoXmlTag("FinInstrmQty")]
        public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; }
    }
}
