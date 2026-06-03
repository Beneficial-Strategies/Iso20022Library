// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Proprietary status related to an instruction.</summary>
    [IsoId("_rt3LR474EfCbNJ3GwkFTcw")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
