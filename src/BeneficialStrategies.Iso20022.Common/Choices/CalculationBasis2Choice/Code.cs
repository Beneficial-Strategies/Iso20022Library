// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CalculationBasis2Choice
{
    /// <summary>Calculation basis expressed as an ISO 20022 code.</summary>
    [IsoId("bdffb6ca-4c60-4db0-9372-169a4380f07b")]
    [DisplayName("Code")]
    public record Code : CalculationBasis2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CalculationBasis2Code Value { get; init; }
    }
}
