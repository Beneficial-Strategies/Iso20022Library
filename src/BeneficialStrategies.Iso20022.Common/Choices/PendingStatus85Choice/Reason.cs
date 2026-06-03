// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus85Choice
{
    /// <summary>Specifies the reason for the pending status.</summary>
    [IsoId("_iigMCbMZEfCEXew4g5B5oA")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus85Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason35 Value { get; init; }
    }
}
