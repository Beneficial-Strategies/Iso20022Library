// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage2Choice
{
    /// <summary>Specifies the settlement reporting initiation message.</summary>
    [IsoId("_kNBj1W7-EfC68Y4jZPNEug")]
    [DisplayName("Settlement Reporting Initiation")]
    public record SettlementReportingInitiation : RecordMessage2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SttlmRptgInitn")]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
