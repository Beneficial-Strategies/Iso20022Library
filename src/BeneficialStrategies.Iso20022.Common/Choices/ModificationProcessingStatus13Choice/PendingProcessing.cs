// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Modification is pending processing.</summary>
    [IsoId("5707f8f3-897c-4627-b323-338c66c1e058")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus13Choice_ Value { get; init; }
    }
}
