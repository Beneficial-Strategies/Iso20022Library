// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus86Choice
{
    /// <summary>Specifies the reason for the pending status.</summary>
    [IsoId("_G8NwCbMaEfCEXew4g5B5oA")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason36 Value { get; init; }
    }
}
