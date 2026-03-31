// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat1Choice
{
    /// <summary>
    /// Price expressed as an amount per a quantity of financial instruments.
    /// </summary>
    [IsoId("_QatkGNp-Ed-ak6NoX_4Aeg_-935448703")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    [IsoXmlTag("AmtPricPerFinInstrmQty")]
    public record AmountPricePerFinancialInstrumentQuantity : PriceFormat1Choice_
    {
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QbAfB9p-Ed-ak6NoX_4Aeg_-1342218248")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; }

        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QbJo8Np-Ed-ak6NoX_4Aeg_-1342218247")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_QbJo8dp-Ed-ak6NoX_4Aeg_-1312665173")]
        [DisplayName("Financial Instrument Quantity")]
        [IsoXmlTag("FinInstrmQty")]
        public required UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; }
    }
}
