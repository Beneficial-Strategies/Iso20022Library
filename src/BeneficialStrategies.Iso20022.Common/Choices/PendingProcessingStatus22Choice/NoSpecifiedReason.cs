// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus22Choice
{
    /// <summary>Reason not specified.</summary>
    [IsoId("_hCkDNaoZEfCG2_q2WT-90w")]
    [DisplayName("No Specified Reason")]
    public record NoSpecifiedReason : PendingProcessingStatus22Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
