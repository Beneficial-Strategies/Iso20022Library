// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the key exchange initiation message.</summary>
    [IsoId("_kNBjvW7-EfC68Y4jZPNEug")]
    [DisplayName("Key Exchange Initiation")]
    public record KeyExchangeInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("KeyXchgInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
