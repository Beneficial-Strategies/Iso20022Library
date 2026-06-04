// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Status43Choice
{
    /// <summary>Status expressed as an instruction processing status.</summary>
    [IsoId("bf16ee75-eda8-48a4-a680-402b4d75dedd")]
    [DisplayName("Instruction Processing Status")]
    public record InstructionProcessingStatus : Status43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InstrPrcgSts")]
        public required InstructionProcessingStatus61Choice_ Value { get; init; }
    }
}
