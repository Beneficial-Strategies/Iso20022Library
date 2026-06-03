// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fraud disposition response message.</summary>
    [IsoId("_kNBjs27-EfC68Y4jZPNEug")]
    [DisplayName("Fraud Disposition Response")]
    public record FraudDispositionResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrdDspstnRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
