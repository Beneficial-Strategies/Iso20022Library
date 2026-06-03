// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason22Choice
{
    /// <summary>Specifies the reason why the instruction has a pending processing status.</summary>
    [IsoId("_rgRelaohEfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingProcessingReason22Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason8Code Value { get; init; }
    }
}
