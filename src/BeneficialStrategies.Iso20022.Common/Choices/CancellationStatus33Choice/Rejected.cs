// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus33Choice
{
    /// <summary>Status of the order cancellation request is rejected.</summary>
    [IsoId("cc4d3a57-da76-4cd7-96bd-b5fc7f6b5f5b")]
    [DisplayName("Rejected")]
    public record Rejected : CancellationStatus33Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus13 Value { get; init; }
    }
}
