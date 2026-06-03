// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity7Choice
{
    /// <summary>Quantity of financial instruments of the linked transaction to be paired-off.</summary>
    [IsoId("abd8ef64-ab7c-4d91-b1dd-eeae46299fc8")]
    [DisplayName("Paired Off Quantity")]
    public record PairedOffQuantity : PairedOrTurnedQuantity7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PairdOffQty")]
        public required FinancialInstrumentQuantity33Choice_ Value { get; init; }
    }
}
