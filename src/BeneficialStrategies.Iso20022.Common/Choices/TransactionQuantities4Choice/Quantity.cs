// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities4Choice
{
    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    public record Quantity : TransactionQuantities4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity33Choice_ Value { get; init; }
    }
}
