// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus82Choice
{
    /// <summary>Specifies the reason of the pending status.</summary>
    [IsoId("_u_FrsaodEfCG2_q2WT-90w")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingReason36 Value { get; init; }
    }
}
