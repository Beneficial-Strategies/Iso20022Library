// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the key exchange response message.</summary>
    [IsoId("_kNBjv27-EfC68Y4jZPNEug")]
    [DisplayName("Key Exchange Response")]
    public record KeyExchangeResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("KeyXchgRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
