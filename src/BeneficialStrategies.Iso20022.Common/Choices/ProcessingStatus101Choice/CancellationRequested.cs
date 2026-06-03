// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the cancellation requested status.</summary>
    [IsoId("15d2c53b-d8c2-4ef5-933c-d4387e817034")]
    [DisplayName("Cancellation Requested")]
    public record CancellationRequested : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlReqd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
