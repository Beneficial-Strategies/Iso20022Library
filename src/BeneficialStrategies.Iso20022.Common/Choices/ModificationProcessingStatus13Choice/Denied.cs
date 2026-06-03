// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Modification request will not be executed.</summary>
    [IsoId("cfdd792f-3676-48ef-be7b-a4cdcffc4698")]
    [DisplayName("Denied")]
    public record Denied : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dnd")]
        public required DeniedStatus15Choice_ Value { get; init; }
    }
}
