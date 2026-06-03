// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus17Choice
{
    /// <summary>Reason for the pending cancellation status.</summary>
    [IsoId("_dZcQyd8QEe-NrtAAlrBEgQ")]
    [DisplayName("Reason")]
    public record Reason : PendingCancellationStatus17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingCancellationStatusReason12 Value { get; init; }
    }
}
