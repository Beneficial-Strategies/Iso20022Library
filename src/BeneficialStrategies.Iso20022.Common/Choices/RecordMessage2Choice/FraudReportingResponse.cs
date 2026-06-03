// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the fraud reporting response message.</summary>
    [IsoId("_kNBjt27-EfC68Y4jZPNEug")]
    [DisplayName("Fraud Reporting Response")]
    public record FraudReportingResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrdRptgRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
