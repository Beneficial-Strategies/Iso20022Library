// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity48Choice
{
    /// <summary>Amount of money to be received following redemption of fund units. Net Amount = (Quantity * Price) - (Fees + Taxes).</summary>
    [IsoId("0eae4ddf-782b-488b-91a2-510ba80ff2fb")]
    [DisplayName("Net Amount")]
    public record NetAmount : FinancialInstrumentQuantity48Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NetAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
