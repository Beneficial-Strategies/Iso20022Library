// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Consolidated Tape Association (CTA) identifier.</summary>
    [IsoId("618f35dd-63f5-43ff-a9ac-094c37db5d49")]
    [DisplayName("CTA")]
    public record CTA : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CTA")]
        public required IsoConsolidatedTapeAssociationIdentifier Value { get; init; }
    }
}
