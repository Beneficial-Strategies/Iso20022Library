// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Instruction has been accepted and forwarded to the next intermediary in the chain.</summary>
    [IsoId("_rt3LIY74EfCbNJ3GwkFTcw")]
    [DisplayName("Forwarded")]
    public record Forwarded : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Fwdd")]
        public required ForwardedStatus1 Value { get; init; }
    }
}
