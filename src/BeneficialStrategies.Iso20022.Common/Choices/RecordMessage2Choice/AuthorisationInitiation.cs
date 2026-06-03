// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the authorisation initiation message.</summary>
    [IsoId("_kNBjl27-EfC68Y4jZPNEug")]
    [DisplayName("Authorisation Initiation")]
    public record AuthorisationInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AuthstnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
