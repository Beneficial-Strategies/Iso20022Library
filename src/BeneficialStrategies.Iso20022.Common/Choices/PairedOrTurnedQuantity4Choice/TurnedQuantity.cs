// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity4Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be turned.
    /// </summary>
    [IsoId("_5xlnq5NLEeWGlc8L7oPDIg")]
    [DisplayName("Turned Quantity")]
    public record TurnedQuantity : PairedOrTurnedQuantity4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TrndQty")]
        public required FinancialInstrumentQuantity15Choice_ Value { get; init; }
    }
}
