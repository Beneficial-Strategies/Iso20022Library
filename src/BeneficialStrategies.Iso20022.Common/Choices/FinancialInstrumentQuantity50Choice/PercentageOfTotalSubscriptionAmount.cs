// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Percentage of the total switch amount (buy-driven) to be invested in a particular investment fund or investment fund class.</summary>
    [IsoId("3de9a4bb-1635-44f1-b0c8-9bdc1ab3f27d")]
    [DisplayName("Percentage Of Total Subscription Amount")]
    public record PercentageOfTotalSubscriptionAmount : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PctgOfTtlSbcptAmt")]
        public required IsoPercentageRate Value { get; init; }
    }
}
