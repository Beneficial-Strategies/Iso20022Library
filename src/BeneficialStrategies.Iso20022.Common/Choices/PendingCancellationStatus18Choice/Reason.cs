// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus18Choice
{
    /// <summary>Reason for the pending cancellation status.</summary>
    [IsoId("_vtSHCaLNEfCHi7w3_0pcpw")]
    [DisplayName("Reason")]
    public record Reason : PendingCancellationStatus18Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingCancellationStatusReason13 Value { get; init; }
    }
}
