// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the pending processing status.</summary>
    [IsoId("3464bdad-634a-4911-b433-715823d953e6")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus21Choice_ Value { get; init; }
    }
}
