// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Swiss Valoren identifier.</summary>
    [IsoId("c3d4b1a3-58db-4e54-9726-5b6c38247c73")]
    [DisplayName("Valoren")]
    public record Valoren : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Vlrn")]
        public required IsoValorenIdentifier Value { get; init; }
    }
}
