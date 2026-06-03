// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice
{
    /// <summary>Specifies the pending processing status.</summary>
    [IsoId("321b4a23-9e06-499a-9fe2-db5e940b9023")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus22Choice_ Value { get; init; }
    }
}
