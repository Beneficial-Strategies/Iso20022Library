// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice
{
    /// <summary>Specifies the cancellation requested status.</summary>
    [IsoId("5664f4df-9e82-459d-8d88-c23ef123e8af")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : ProcessingStatus104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
