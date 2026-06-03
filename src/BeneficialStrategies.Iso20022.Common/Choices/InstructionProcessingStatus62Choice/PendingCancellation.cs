// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus62Choice
{
    /// <summary>Cancellation instruction is pending.</summary>
    [IsoId("_H9hec68wEfCx2aBifPEdRg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus62Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus21Choice_ Value { get; init; }
    }
}
