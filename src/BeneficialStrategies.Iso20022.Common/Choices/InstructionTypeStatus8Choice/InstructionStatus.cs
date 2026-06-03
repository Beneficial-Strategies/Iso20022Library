// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus8Choice
{
    /// <summary>Status of the instruction.</summary>
    [IsoId("_D2yUwajVEfCzuLlmLrhIvA")]
    [DisplayName("Instruction Status")]
    public record InstructionStatus : InstructionTypeStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InstrSts")]
        public required DetailedInstructionStatus23 Value { get; init; }
    }
}
