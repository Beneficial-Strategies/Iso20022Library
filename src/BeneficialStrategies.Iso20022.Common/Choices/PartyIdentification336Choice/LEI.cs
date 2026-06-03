// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification336Choice
{
    /// <summary>Legal Entity Identifier of the party.</summary>
    [IsoId("_1fJ0EKnVEfC5VNwixU6YfQ")]
    [DisplayName("LEI")]
    public record LEI : PartyIdentification336Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LEI")]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
