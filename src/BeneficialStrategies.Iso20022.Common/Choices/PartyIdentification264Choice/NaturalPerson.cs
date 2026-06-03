// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification264Choice
{
    /// <summary>Identification of a natural person.</summary>
    [IsoId("_Qj13Ia5wEfCUHaCK5HWOhg")]
    [DisplayName("Natural Person")]
    public record NaturalPerson : PartyIdentification264Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NtrlPrsn")]
        public required PartyIdentification342 Value { get; init; }
    }
}
