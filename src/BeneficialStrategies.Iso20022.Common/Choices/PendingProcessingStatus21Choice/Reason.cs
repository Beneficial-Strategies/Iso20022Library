// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus21Choice
{
    /// <summary>Specifies the reason of the pending processing status.</summary>
    [IsoId("ce34299c-4463-4965-9a64-65373171ed6a")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingProcessingReason18 Value { get; init; }
    }
}
