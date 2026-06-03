// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus19Choice
{
    /// <summary>Reason why the meeting instruction cancellation request message or the individual meeting instruction cancellation request is pending.</summary>
    [IsoId("_dNXyKa8uEfCx2aBifPEdRg")]
    [DisplayName("Reason")]
    public record Reason : PendingCancellationStatus19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingCancellationStatusReason14 Value { get; init; }
    }
}
