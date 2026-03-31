// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat94Choice
{
    /// <summary>
    /// Amount Price Per Amount.
    /// </summary>
    [DisplayName("Amount Price Per Amount")]
    public record AmountPricePerAmount : PriceFormat94Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtPricPerAmt")]
        public required AmountPricePerAmount3 Value { get; init; }
    }
}
