// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason19Choice
{
    /// <summary>Specifies the reason why the instruction has a pending processing status.</summary>
    [IsoId("e318786c-e60c-4b1d-9be0-1ccaafb819c9")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingProcessingReason19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
