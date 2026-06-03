// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity51Choice
{
    /// <summary>Quantity expressed as a gross amount of money.</summary>
    [IsoId("62a93a67-a7b3-400f-aab7-9c94851a6782")]
    [DisplayName("Gross Amount")]
    public record GrossAmount : FinancialInstrumentQuantity51Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GrssAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
