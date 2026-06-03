// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus21Choice
{
    /// <summary>Provides status information related to a pending cancellation request.</summary>
    [IsoId("_c8L7OaKvEfCHi7w3_0pcpw")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionCancellationRequestStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus18Choice_ Value { get; init; }
    }
}
