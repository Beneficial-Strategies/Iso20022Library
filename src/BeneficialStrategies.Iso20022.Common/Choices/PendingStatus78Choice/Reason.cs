// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus78Choice
{
    /// <summary>Reason for the pending status.</summary>
    [IsoId("_5ABoud8EEe-NrtAAlrBEgQ")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus78Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason32 Value { get; init; }
    }
}
