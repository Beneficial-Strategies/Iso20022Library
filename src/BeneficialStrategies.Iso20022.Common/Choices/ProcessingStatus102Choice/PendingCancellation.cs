// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the pending cancellation status.</summary>
    [IsoId("125f5a4d-8d49-43b0-9b40-dad709cbd461")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus81Choice_ Value { get; init; }
    }
}
