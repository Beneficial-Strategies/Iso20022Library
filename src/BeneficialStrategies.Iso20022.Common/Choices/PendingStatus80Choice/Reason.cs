// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus80Choice
{
    /// <summary>Reason for the pending status.</summary>
    [IsoId("_Cbb1yaKuEfCHi7w3_0pcpw")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus80Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason33 Value { get; init; }
    }
}
