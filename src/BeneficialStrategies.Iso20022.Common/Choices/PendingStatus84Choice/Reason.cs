// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus84Choice
{
    /// <summary>Specifies the reason for the pending status.</summary>
    [IsoId("_RlhDQbMVEfCEXew4g5B5oA")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus84Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason34 Value { get; init; }
    }
}
