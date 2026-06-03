// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity48Choice
{
    /// <summary>Amount of money to be redeemed from the fund. Gross Amount = Quantity * Price.</summary>
    [IsoId("f2020865-6417-4446-b050-67b5590ea3b6")]
    [DisplayName("Gross Amount")]
    public record GrossAmount : FinancialInstrumentQuantity48Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GrssAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
