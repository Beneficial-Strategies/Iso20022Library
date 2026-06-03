// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource6Choice
{
    /// <summary>Unique and unambiguous identification source using a proprietary identification scheme.</summary>
    [IsoId("3f962c98-e0be-447a-8528-56e8508a79d8")]
    [DisplayName("Proprietary")]
    public record Proprietary : IdentificationSource6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
