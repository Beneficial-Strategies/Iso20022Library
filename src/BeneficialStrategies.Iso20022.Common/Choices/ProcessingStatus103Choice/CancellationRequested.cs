// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the cancellation requested status.</summary>
    [IsoId("b467eb6d-f82d-4b2d-a317-689c7c322457")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
