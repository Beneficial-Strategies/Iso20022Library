// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Rate used to calculate the quantity of securities to be redeemed.</summary>
    [IsoId("b8c1c4f4-d627-4d60-84b7-c255c7663b35")]
    [DisplayName("Holdings Redemption Rate")]
    public record HoldingsRedemptionRate : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("HldgsRedRate")]
        public required IsoPercentageRate Value { get; init; }
    }
}
