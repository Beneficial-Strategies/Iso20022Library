// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus11Choice
{
    /// <summary>Instruction is accepted but in repair.</summary>
    [IsoId("0b5d2d78-6645-4b7a-98ab-650f83dd5797")]
    [DisplayName("Repair")]
    public record Repair : IntraPositionProcessingStatus11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RejectionOrRepairStatus41Choice_ Value { get; init; }
    }
}
