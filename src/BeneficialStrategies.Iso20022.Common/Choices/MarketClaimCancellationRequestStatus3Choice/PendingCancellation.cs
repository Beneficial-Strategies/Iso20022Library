// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice
{
    /// <summary>Instruction cancellation request is pending cancellation.</summary>
    [IsoId("_Jg5gOa8xEfCx2aBifPEdRg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : MarketClaimCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus22Choice_ Value { get; init; }
    }
}
