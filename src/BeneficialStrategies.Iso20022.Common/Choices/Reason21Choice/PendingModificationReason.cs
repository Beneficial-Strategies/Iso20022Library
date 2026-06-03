// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the pending modification reason.</summary>
    [IsoId("8a39ff25-0e15-4920-8ad5-436cc0397587")]
    [DisplayName("Pending Modification Reason")]
    public record PendingModificationReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgModRsn")]
        public required PendingReason28Choice_ Value { get; init; }
    }
}
