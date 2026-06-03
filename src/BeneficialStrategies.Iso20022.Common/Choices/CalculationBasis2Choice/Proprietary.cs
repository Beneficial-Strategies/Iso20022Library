// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CalculationBasis2Choice
{
    /// <summary>Calculation basis expressed as an extended code.</summary>
    [IsoId("c1908255-ee38-4965-a2af-613a0de86a7c")]
    [DisplayName("Proprietary")]
    public record Proprietary : CalculationBasis2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
