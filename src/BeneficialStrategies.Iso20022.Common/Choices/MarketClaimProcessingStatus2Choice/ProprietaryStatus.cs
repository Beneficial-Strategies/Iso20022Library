// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Proprietary status information.</summary>
    [IsoId("_G1D_Q7MaEfCEXew4g5B5oA")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
