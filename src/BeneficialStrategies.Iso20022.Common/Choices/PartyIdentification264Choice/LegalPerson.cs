// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification264Choice
{
    /// <summary>Identification of a legal person.</summary>
    [IsoId("_Qj1QEa5wEfCUHaCK5HWOhg")]
    [DisplayName("Legal Person")]
    public record LegalPerson : PartyIdentification264Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LglPrsn")]
        public required PartyIdentification341 Value { get; init; }
    }
}
