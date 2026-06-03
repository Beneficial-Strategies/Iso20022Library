// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the authorisation response message.</summary>
    [IsoId("_kNBjmW7-EfC68Y4jZPNEug")]
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AuthstnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
