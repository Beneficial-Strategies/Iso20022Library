// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification335Choice
{
    /// <summary>Party identification.</summary>
    [IsoId("_YdfbsanVEfC5VNwixU6YfQ")]
    [DisplayName("Party")]
    public record Party : PartyIdentification335Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pty")]
        public required PartyIdentification336Choice_ Value { get; init; }
    }
}
