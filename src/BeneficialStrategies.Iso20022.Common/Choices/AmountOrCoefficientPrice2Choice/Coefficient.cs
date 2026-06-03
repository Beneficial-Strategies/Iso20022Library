// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrCoefficientPrice2Choice
{
    /// <summary>Provides details of the price when expressed with a coefficient.</summary>
    [IsoId("_NGNiA2ejEeqY_MU7lK4HCA")]
    [DisplayName("Coefficient")]
    public record Coefficient : AmountOrCoefficientPrice2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Coeff")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
