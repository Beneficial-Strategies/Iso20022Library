// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus100Choice
{
    /// <summary>Specifies the cancelled status.</summary>
    [IsoId("_XXEmgY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus100Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus14Choice_ Value { get; init; }
    }
}
