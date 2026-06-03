// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity48Choice
{
    /// <summary>Portion of the investor's holdings to be redeemed.</summary>
    [IsoId("26c4eb0c-4d21-4986-a36f-5f0aa7440cab")]
    [DisplayName("Holdings Redemption Rate")]
    public record HoldingsRedemptionRate : FinancialInstrumentQuantity48Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("HldgsRedRate")]
        public required IsoPercentageRate Value { get; init; }
    }
}
