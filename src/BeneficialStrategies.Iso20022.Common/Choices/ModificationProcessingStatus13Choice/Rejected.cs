// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Modification request has been rejected for further processing.</summary>
    [IsoId("752cc955-d409-45ae-a751-ae4d7534606c")]
    [DisplayName("Rejected")]
    public record Rejected : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus37Choice_ Value { get; init; }
    }
}
