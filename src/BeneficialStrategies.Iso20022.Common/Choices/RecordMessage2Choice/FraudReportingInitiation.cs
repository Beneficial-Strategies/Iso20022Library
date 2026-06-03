// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fraud reporting initiation message.</summary>
    [IsoId("_kNBjtW7-EfC68Y4jZPNEug")]
    [DisplayName("Fraud Reporting Initiation")]
    public record FraudReportingInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrdRptgInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
