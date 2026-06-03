// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the pending reason.</summary>
    [IsoId("145eeb5c-8daf-4a85-9ffc-45d7dcc47c7a")]
    [DisplayName("Pending Reason")]
    public record PendingReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgRsn")]
        public required PendingReason78Choice_ Value { get; init; }
    }
}
