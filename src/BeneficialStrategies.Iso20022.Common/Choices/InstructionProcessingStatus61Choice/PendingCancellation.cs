// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Instruction cancellation is pending.</summary>
    [IsoId("fe32299c-8490-4c66-96a7-e62f9c8eb479")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus81Choice_ Value { get; init; }
    }
}
