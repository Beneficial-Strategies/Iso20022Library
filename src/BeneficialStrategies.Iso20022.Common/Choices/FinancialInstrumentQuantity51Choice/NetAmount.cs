// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity51Choice
{
    /// <summary>Quantity expressed as a net amount of money.</summary>
    [IsoId("016bef78-b272-42a4-aaef-d2e24de08d1a")]
    [DisplayName("Net Amount")]
    public record NetAmount : FinancialInstrumentQuantity51Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NetAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
