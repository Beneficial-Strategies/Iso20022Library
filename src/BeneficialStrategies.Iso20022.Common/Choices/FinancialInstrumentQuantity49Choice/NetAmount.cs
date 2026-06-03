// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity49Choice
{
    /// <summary>Quantity expressed as a net amount of money.</summary>
    [IsoId("9f4dae3a-7efa-4946-b16b-1682b9fb4d5f")]
    [DisplayName("Net Amount")]
    public record NetAmount : FinancialInstrumentQuantity49Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NetAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
