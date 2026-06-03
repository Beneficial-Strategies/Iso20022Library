// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Modification request has been rejected for further processing.</summary>
    [IsoId("_rZrHc6ohEfCG2_q2WT-90w")]
    [DisplayName("Rejected")]
    public record Rejected : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus37Choice_ Value { get; init; }
    }
}
