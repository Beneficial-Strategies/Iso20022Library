// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat68Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per financial instrument quantity.
    /// </summary>
    [IsoId("_plY1hzi7Eeydid5dcNPKvg")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    public record AmountPricePerFinancialInstrumentQuantity : PriceFormat68Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_pi0pATi7Eeydid5dcNPKvg")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_pi0pCTi7Eeydid5dcNPKvg")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_pi0pETi7Eeydid5dcNPKvg")]
        [DisplayName("Financial Instrument Quantity")]
        [IsoXmlTag("FinInstrmQty")]
        public required FinancialInstrumentQuantity36Choice_ FinancialInstrumentQuantity { get; init; }
    }
}
