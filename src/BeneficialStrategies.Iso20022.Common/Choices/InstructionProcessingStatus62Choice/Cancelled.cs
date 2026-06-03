// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Instruction cancelled by client cancellation instruction.</summary>
    [IsoId("_H9heU68wEfCx2aBifPEdRg")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatus12Choice_ Value { get; init; }
    }
}
