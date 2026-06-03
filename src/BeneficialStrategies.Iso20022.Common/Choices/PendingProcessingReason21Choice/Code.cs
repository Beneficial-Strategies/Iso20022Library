// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason21Choice
{
    /// <summary>Specifies the reason why the instruction has a pending processing status.</summary>
    [IsoId("_XoK6daobEfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingProcessingReason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason7Code Value { get; init; }
    }
}
