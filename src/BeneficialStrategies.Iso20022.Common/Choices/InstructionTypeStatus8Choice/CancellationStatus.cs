// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus8Choice
{
    /// <summary>Status applying to the instruction cancellation request received.</summary>
    [IsoId("_D2yUw6jVEfCzuLlmLrhIvA")]
    [DisplayName("Cancellation Status")]
    public record CancellationStatus : InstructionTypeStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlSts")]
        public required CancellationStatus34Choice_ Value { get; init; }
    }
}
