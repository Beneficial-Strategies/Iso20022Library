// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice
{
    /// <summary>Instruction cancellation request has been completed.</summary>
    [IsoId("_Jg5gIa8xEfCx2aBifPEdRg")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : MarketClaimCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlCmpltd")]
        public required CancelledStatus11Choice_ Value { get; init; }
    }
}
