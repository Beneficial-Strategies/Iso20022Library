// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification262Choice
{
    /// <summary>Identification of the party expressed as a BIC.</summary>
    [IsoId("e2ae7976-22fd-49c3-b368-82c4b6d9c42d")]
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification262Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AnyBIC")]
        public required IsoAnyBICDec2014Identifier Value { get; init; }
    }
}
