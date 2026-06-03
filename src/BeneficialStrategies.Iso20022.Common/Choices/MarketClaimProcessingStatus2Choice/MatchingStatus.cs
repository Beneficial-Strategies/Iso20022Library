// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Provides the matching status of the instruction.</summary>
    [IsoId("_G1D_QbMaEfCEXew4g5B5oA")]
    [DisplayName("Matching Status")]
    public record MatchingStatus : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MtchgSts")]
        public required MatchingStatus34Choice_ Value { get; init; }
    }
}
