// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Instruction processing has been rejected.</summary>
    [IsoId("_G1D_MbMaEfCEXew4g5B5oA")]
    [DisplayName("Rejected")]
    public record Rejected : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus37Choice_ Value { get; init; }
    }
}
