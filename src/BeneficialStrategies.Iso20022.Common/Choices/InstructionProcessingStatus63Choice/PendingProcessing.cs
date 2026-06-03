// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Processing of the instruction is pending.</summary>
    [IsoId("_9ENHsQNrEfG_3cM8uyJ20w")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus20Choice_ Value { get; init; }
    }
}
