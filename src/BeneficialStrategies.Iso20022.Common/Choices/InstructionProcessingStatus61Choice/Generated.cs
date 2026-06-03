// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Instruction has been generated.</summary>
    [IsoId("35559f13-aca3-4e14-a005-c4137068db20")]
    [DisplayName("Generated")]
    public record Generated : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Gnrtd")]
        public required GeneratedStatus7Choice_ Value { get; init; }
    }
}
