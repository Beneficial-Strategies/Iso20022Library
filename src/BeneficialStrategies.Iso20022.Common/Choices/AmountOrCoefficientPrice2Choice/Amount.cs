// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrCoefficientPrice2Choice
{
    /// <summary>Provides details of the price when expressed with an amount and implied currency.</summary>
    [IsoId("_NGNiAWejEeqY_MU7lK4HCA")]
    [DisplayName("Amount")]
    public record Amount : AmountOrCoefficientPrice2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Amt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
