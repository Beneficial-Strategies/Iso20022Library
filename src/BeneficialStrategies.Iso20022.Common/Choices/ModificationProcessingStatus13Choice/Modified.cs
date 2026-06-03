// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Instruction has been modified.</summary>
    [IsoId("60641b6f-c98f-457d-a68f-41df8eae06f6")]
    [DisplayName("Modified")]
    public record Modified : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Modfd")]
        public required ModificationStatus6Choice_ Value { get; init; }
    }
}
