// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fraud disposition initiation message.</summary>
    [IsoId("_kNBjsW7-EfC68Y4jZPNEug")]
    [DisplayName("Fraud Disposition Initiation")]
    public record FraudDispositionInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrdDspstnInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
