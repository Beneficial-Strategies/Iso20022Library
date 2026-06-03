// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fee collection response message.</summary>
    [IsoId("_kNBjp27-EfC68Y4jZPNEug")]
    [DisplayName("Fee Collection Response")]
    public record FeeCollectionResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FeeColltnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
