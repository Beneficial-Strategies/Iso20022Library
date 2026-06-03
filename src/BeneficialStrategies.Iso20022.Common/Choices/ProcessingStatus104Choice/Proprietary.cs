// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("bff1ea2f-1ca9-4b44-aee6-a15370d9cb62")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus104Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
