// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification263Choice
{
    /// <summary>Legal Entity Identifier of the party.</summary>
    [IsoId("_GNgo0a3pEfCN-rGCydxGUA")]
    [DisplayName("LEI")]
    public record LEI : PartyIdentification263Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LEI")]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
