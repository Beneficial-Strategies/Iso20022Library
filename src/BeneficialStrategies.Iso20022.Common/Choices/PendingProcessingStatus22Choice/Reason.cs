// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus22Choice
{
    /// <summary>Specifies the reason of the pending processing status.</summary>
    [IsoId("_hCkDQaoZEfCG2_q2WT-90w")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingStatus22Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingProcessingReason19 Value { get; init; }
    }
}
