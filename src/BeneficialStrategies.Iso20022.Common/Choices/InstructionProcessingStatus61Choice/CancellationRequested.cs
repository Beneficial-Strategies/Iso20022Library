// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus61Choice
{
    /// <summary>Cancellation has been requested.</summary>
    [IsoId("73165cd2-1dbc-4629-8cd7-6758336cf8a7")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : InstructionProcessingStatus61Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
