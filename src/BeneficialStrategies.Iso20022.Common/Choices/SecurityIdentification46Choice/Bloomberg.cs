// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Bloomberg identifier.</summary>
    [IsoId("b2899719-5f62-48e8-9016-c3622ef01f7b")]
    [DisplayName("Bloomberg")]
    public record Bloomberg : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Blmbrg")]
        public required IsoBloombergIdentifier Value { get; init; }
    }
}
