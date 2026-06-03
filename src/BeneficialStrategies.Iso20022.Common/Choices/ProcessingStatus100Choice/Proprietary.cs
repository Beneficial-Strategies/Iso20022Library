// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus100Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("_XXEmiY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus100Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
