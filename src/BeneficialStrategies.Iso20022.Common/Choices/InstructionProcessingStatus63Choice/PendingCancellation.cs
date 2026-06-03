// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Cancellation request is pending further processing.</summary>
    [IsoId("_9ENHyQNrEfG_3cM8uyJ20w")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus81Choice_ Value { get; init; }
    }
}
