// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice
{
    /// <summary>Specifies the pending cancellation status.</summary>
    [IsoId("d2510a97-8d4a-4cac-b307-b867f3752efe")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus81Choice_ Value { get; init; }
    }
}
