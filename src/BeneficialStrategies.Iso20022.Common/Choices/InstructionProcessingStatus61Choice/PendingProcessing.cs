// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Instruction is pending processing.</summary>
    [IsoId("24bec065-9f87-42df-a966-ae9acc877bad")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus20Choice_ Value { get; init; }
    }
}
