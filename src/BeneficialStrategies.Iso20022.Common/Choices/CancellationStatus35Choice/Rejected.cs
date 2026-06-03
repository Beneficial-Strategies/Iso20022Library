// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus35Choice
{
    /// <summary>Status advising on the rejection of the instruction cancellation request and on the reason for the rejection.</summary>
    [IsoId("_dFg2o68uEfCx2aBifPEdRg")]
    [DisplayName("Rejected")]
    public record Rejected : CancellationStatus35Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus31Choice_ Value { get; init; }
    }
}
