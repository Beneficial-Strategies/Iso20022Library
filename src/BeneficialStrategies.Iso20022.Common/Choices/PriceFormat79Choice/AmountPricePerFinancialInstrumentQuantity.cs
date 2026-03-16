// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat79Choice
{
    /// <summary>
    /// Amount Price Per Financial Instrument Quantity.
    /// </summary>
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    public record AmountPricePerFinancialInstrumentQuantity : PriceFormat79Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtPricPerFinInstrmQty")]
        public required AmountPricePerFinancialInstrumentQuantity10 Value { get; init; }
    }
}
