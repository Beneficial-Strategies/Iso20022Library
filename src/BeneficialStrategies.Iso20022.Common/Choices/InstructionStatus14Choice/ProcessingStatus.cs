// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus14Choice
{
    /// <summary>Status advising on the processing of the instruction.</summary>
    [IsoId("_EFISwajVEfCzuLlmLrhIvA")]
    [DisplayName("Processing Status")]
    public record ProcessingStatus : InstructionStatus14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrcgSts")]
        public required InstructionProcessingStatus6 Value { get; init; }
    }
}
