// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus20Choice
{
    /// <summary>Provides status information related to a pending cancellation request.</summary>
    [IsoId("_s9Gd598OEe-NrtAAlrBEgQ")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionCancellationRequestStatus20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus17Choice_ Value { get; init; }
    }
}
