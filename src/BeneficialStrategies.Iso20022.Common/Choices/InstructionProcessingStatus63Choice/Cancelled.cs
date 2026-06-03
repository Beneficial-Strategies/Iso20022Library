// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Instruction has been cancelled.</summary>
    [IsoId("_9ENHvQNrEfG_3cM8uyJ20w")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus24Choice_ Value { get; init; }
    }
}
