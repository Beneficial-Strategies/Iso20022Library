// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus63Choice
{
    /// <summary>Cancellation has been requested.</summary>
    [IsoId("_9ENHtQNrEfG_3cM8uyJ20w")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : InstructionProcessingStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
