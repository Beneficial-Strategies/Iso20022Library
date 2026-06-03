// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Instruction has been acknowledged by the account servicer.</summary>
    [IsoId("_9ENHuQNrEfG_3cM8uyJ20w")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus21Choice_ Value { get; init; }
    }
}
