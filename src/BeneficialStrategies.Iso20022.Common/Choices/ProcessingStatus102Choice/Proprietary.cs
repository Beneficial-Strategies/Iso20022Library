// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("a829dcb7-48eb-4507-80a9-4698708f38d0")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
