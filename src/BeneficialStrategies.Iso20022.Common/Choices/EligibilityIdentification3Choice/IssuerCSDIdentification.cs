// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification3Choice
{
    /// <summary>Issuer CSD identification used to identify the securities to be defined as eligible.</summary>
    [IsoId("_xHPWtWc-EemvNLufWGIVOQ")]
    [DisplayName("Issuer CSD Identification")]
    public record IssuerCSDIdentification : EligibilityIdentification3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IssrCSDId")]
        public required SystemPartyIdentification2Choice_ Value { get; init; }
    }
}
