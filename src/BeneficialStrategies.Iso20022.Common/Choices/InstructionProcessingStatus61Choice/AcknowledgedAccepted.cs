// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Instruction has been acknowledged and accepted.</summary>
    [IsoId("91d2a333-957b-4d80-82e2-019ccc46a80e")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus21Choice_ Value { get; init; }
    }
}
