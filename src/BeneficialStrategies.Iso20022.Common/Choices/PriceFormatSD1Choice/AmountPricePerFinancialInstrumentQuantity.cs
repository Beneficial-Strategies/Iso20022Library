// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormatSD1Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per financial instrument quantity.
    /// </summary>
    [IsoId("_1lQORDL3EeKU9IrkkToqcw_1686025671")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    public partial record AmountPricePerFinancialInstrumentQuantity : PriceFormatSD1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_WjDbUNp-Ed-ak6NoX_4Aeg_613105185")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; } 
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_WjDbUdp-Ed-ak6NoX_4Aeg_-1381039521")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        
        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_WjDbUtp-Ed-ak6NoX_4Aeg_1787125323")]
        [DisplayName("Financial Instrument Quantity")]
        [IsoXmlTag("FinInstrmQty")]
        public required FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; } 
        
        
        #nullable disable
        
    }
}
