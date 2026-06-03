// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus59Choice
{
    /// <summary>Proprietary status related to an instruction.</summary>
    [IsoId("_j-yrwd75Ee-NrtAAlrBEgQ")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : InstructionProcessingStatus59Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
