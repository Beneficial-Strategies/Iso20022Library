// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Instruction is accepted but in repair.</summary>
    [IsoId("_9ENHxQNrEfG_3cM8uyJ20w")]
    [DisplayName("Repair")]
    public record Repair : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus12Choice_ Value { get; init; }
    }
}
