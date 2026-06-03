// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification336Choice
{
    /// <summary>Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority.</summary>
    [IsoId("_1fJ0EanVEfC5VNwixU6YfQ")]
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification336Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AnyBIC")]
        public required IsoAnyBICDec2014Identifier Value { get; init; }
    }
}
