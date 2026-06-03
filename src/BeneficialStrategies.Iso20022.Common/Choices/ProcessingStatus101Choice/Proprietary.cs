// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("4dd7da73-fdc2-4ed7-a1b7-2e63eb8568a5")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
