// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice
{
    /// <summary>Proprietary status information.</summary>
    [IsoId("_Jg5gQa8xEfCx2aBifPEdRg")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : MarketClaimCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
