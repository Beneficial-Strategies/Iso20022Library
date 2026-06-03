// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Instruction has been modified.</summary>
    [IsoId("_rZrHf6ohEfCG2_q2WT-90w")]
    [DisplayName("Modified")]
    public record Modified : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Modfd")]
        public required ModificationStatus6Choice_ Value { get; init; }
    }
}
