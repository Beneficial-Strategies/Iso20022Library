// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>German Wertpapier identifier.</summary>
    [IsoId("b9a360c7-fd09-4a12-8977-aaf366c4cb65")]
    [DisplayName("Wertpapier")]
    public record Wertpapier : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Wrtppr")]
        public required IsoWertpapierIdentifier Value { get; init; }
    }
}
