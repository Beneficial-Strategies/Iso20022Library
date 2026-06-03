// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Default action is taken.</summary>
    [IsoId("_rt3LNY74EfCbNJ3GwkFTcw")]
    [DisplayName("Default Action")]
    public record DefaultAction : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DfltActn")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
