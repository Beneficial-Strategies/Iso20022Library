// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the pending processing status.</summary>
    [IsoId("5631332f-1b84-43d3-9fd3-2a6be8e40c2b")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus20Choice_ Value { get; init; }
    }
}
