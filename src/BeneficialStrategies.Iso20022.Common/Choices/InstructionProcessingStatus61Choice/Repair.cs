// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Instruction is in repair.</summary>
    [IsoId("218d8bf7-90e8-49bc-982a-3e0949e4d7a6")]
    [DisplayName("Repair")]
    public record Repair : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RepairStatus12Choice_ Value { get; init; }
    }
}
