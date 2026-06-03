// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus22Choice
{
    /// <summary>Reason for the pending cancellation status.</summary>
    [IsoId("_JnvH-a8xEfCx2aBifPEdRg")]
    [DisplayName("Reason")]
    public record Reason : PendingCancellationStatus22Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingCancellationStatusReason17 Value { get; init; }
    }
}
