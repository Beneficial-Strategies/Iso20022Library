// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Instruction processing has been cancelled.</summary>
    [IsoId("_G1D_IbMaEfCEXew4g5B5oA")]
    [DisplayName("Cancelled")]
    public record Cancelled : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatus12Choice_ Value { get; init; }
    }
}
