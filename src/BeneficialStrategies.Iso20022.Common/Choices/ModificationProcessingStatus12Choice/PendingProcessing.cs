// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Modification is pending processing.</summary>
    [IsoId("_rZrHYaohEfCG2_q2WT-90w")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus23Choice_ Value { get; init; }
    }
}
