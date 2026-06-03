// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Standing instruction has been applied.</summary>
    [IsoId("_rt3LPY74EfCbNJ3GwkFTcw")]
    [DisplayName("Standing Instruction")]
    public record StandingInstruction : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("StgInstr")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
