// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Modification request will not be executed.</summary>
    [IsoId("_rZrHZ6ohEfCG2_q2WT-90w")]
    [DisplayName("Denied")]
    public record Denied : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dnd")]
        public required DeniedStatus15Choice_ Value { get; init; }
    }
}
