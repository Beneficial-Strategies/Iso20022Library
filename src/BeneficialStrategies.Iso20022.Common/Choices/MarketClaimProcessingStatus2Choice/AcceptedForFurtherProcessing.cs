// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice
{
    /// <summary>Instruction is accepted for further processing.</summary>
    [IsoId("_G1D_KbMaEfCEXew4g5B5oA")]
    [DisplayName("Accepted For Further Processing")]
    public record AcceptedForFurtherProcessing : MarketClaimProcessingStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AccptdForFrthrPrcg")]
        public required AcceptedStatus8Choice_ Value { get; init; }
    }
}
