// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>French Sicovam identifier.</summary>
    [IsoId("81d4d2d3-38cc-47aa-8e85-9216a8bfcf5c")]
    [DisplayName("Sicovam")]
    public record Sicovam : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SCVM")]
        public required IsoSicovamIdentifier Value { get; init; }
    }
}
