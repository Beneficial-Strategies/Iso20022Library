// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus21Choice
{
    /// <summary>Reason for the pending cancellation status.</summary>
    [IsoId("_IEVQ-a8wEfCx2aBifPEdRg")]
    [DisplayName("Reason")]
    public record Reason : PendingCancellationStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingCancellationStatusReason16 Value { get; init; }
    }
}
