// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Identifier of securities issued in Luxembourg; common code replaces CEDEL and Euroclear codes.</summary>
    [IsoId("150dc2a9-cf22-4ff5-a254-bed4b8c68e6a")]
    [DisplayName("Common")]
    public record Common : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cmon")]
        public required IsoEuroclearClearstreamIdentifier Value { get; init; }
    }
}
