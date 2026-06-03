// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the settlement reporting response message.</summary>
    [IsoId("_kNBj127-EfC68Y4jZPNEug")]
    [DisplayName("Settlement Reporting Response")]
    public record SettlementReportingResponse : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SttlmRptgRspn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
