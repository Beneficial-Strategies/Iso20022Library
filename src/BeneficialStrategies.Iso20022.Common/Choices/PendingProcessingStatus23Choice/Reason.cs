// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus23Choice
{
    /// <summary>Specifies the reason of the pending processing status.</summary>
    [IsoId("_rb4t4aohEfCG2_q2WT-90w")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingStatus23Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingProcessingReason20 Value { get; init; }
    }
}
