// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Proprietary status.</summary>
    [IsoId("_rZruZ6ohEfCG2_q2WT-90w")]
    [DisplayName("Proprietary")]
    public record Proprietary : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
