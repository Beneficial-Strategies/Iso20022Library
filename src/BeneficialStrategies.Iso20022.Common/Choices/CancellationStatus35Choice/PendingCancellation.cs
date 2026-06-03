// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus35Choice
{
    /// <summary>Status advising that the instruction cancellation request is pending and advising on the reason for the pending status.</summary>
    [IsoId("_dFg2pa8uEfCx2aBifPEdRg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : CancellationStatus35Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus19Choice_ Value { get; init; }
    }
}
