// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Instruction processing is pending.</summary>
    [IsoId("_G1D_ObMaEfCEXew4g5B5oA")]
    [DisplayName("Pending")]
    public record Pending : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus86Choice_ Value { get; init; }
    }
}
