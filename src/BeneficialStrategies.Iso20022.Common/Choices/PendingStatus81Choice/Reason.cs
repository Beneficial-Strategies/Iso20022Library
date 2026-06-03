// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus81Choice
{
    /// <summary>Specifies the reason of the pending status.</summary>
    [IsoId("8ce0de1f-65d9-46a1-ab5e-955414a1e858")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus81Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingReason35 Value { get; init; }
    }
}
