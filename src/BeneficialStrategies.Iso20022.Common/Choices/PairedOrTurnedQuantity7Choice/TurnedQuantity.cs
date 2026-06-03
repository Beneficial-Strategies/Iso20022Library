// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity7Choice
{
    /// <summary>Quantity of financial instruments of the linked transaction to be turned.</summary>
    [IsoId("48c897fd-16b3-4c8a-a983-c5b64a832434")]
    [DisplayName("Turned Quantity")]
    public record TurnedQuantity : PairedOrTurnedQuantity7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TrndQty")]
        public required FinancialInstrumentQuantity33Choice_ Value { get; init; }
    }
}
