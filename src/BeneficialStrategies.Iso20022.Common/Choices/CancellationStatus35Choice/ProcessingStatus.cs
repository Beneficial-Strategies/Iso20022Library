// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus35Choice
{
    /// <summary>Status advising on the processing of the instruction cancellation request.</summary>
    [IsoId("_dFg2oa8uEfCx2aBifPEdRg")]
    [DisplayName("Processing Status")]
    public record ProcessingStatus : CancellationStatus35Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrcgSts")]
        public required CancellationProcessingStatus2 Value { get; init; }
    }
}
