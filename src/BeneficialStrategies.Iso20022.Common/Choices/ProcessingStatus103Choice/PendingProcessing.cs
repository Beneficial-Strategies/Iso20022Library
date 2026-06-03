// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the pending processing status.</summary>
    [IsoId("bb89dfb1-601d-4749-bcf2-1bb788b7e21f")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus22Choice_ Value { get; init; }
    }
}
