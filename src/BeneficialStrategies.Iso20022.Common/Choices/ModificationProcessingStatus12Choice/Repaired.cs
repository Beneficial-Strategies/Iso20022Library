// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Modification request is accepted but in repair.</summary>
    [IsoId("_rZrHeaohEfCG2_q2WT-90w")]
    [DisplayName("Repaired")]
    public record Repaired : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rprd")]
        public required RepairStatus13Choice_ Value { get; init; }
    }
}
