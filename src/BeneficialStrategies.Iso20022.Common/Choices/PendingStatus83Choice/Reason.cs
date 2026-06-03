// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus83Choice
{
    /// <summary>Specifies the reason for the pending status.</summary>
    [IsoId("_ltv70aogEfCG2_q2WT-90w")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingReason37 Value { get; init; }
    }
}
