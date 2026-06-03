// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity49Choice
{
    /// <summary>Quantity expressed as a gross amount of money.</summary>
    [IsoId("153b99d8-1a7d-4aaf-9376-f3d3399fd1d3")]
    [DisplayName("Gross Amount")]
    public record GrossAmount : FinancialInstrumentQuantity49Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GrssAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
