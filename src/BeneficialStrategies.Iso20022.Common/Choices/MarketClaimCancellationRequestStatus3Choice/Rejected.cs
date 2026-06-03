// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice
{
    /// <summary>Instruction cancellation request has been rejected.</summary>
    [IsoId("_Jg5gMa8xEfCx2aBifPEdRg")]
    [DisplayName("Rejected")]
    public record Rejected : MarketClaimCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus38Choice_ Value { get; init; }
    }
}
