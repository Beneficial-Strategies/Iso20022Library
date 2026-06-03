// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the pending cancellation reason.</summary>
    [IsoId("d27b430d-6925-468e-bfe2-7dfa7e6e04f4")]
    [DisplayName("Pending Cancellation Reason")]
    public record PendingCancellationReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxlRsn")]
        public required PendingCancellationReasons6Choice_ Value { get; init; }
    }
}
