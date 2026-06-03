// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus20Choice
{
    /// <summary>Specifies the reason of the pending processing status.</summary>
    [IsoId("5cfb8695-a489-4e2f-bf7b-133b187e4d8d")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingStatus20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingProcessingReason17 Value { get; init; }
    }
}
