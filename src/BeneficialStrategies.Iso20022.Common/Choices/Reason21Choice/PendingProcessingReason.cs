// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the pending processing reason.</summary>
    [IsoId("408ff176-07fc-45f6-98b6-256362b6d650")]
    [DisplayName("Pending Processing Reason")]
    public record PendingProcessingReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcgRsn")]
        public required PendingProcessingReason20Choice_ Value { get; init; }
    }
}
