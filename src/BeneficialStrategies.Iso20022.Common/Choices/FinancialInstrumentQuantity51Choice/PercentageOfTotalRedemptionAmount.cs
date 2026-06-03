// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity51Choice
{
    /// <summary>Percentage of the total redemption amount to be redeemed.</summary>
    [IsoId("5d3b5841-cd11-4d16-992a-19846b56026c")]
    [DisplayName("Percentage Of Total Redemption Amount")]
    public record PercentageOfTotalRedemptionAmount : FinancialInstrumentQuantity51Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PctgOfTtlRedAmt")]
        public required IsoPercentageRate Value { get; init; }
    }
}
