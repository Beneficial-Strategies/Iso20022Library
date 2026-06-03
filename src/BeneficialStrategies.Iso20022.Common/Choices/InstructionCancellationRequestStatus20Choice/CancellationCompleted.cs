// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus20Choice
{
    /// <summary>Provides status information related to an instruction cancellation request completed.</summary>
    [IsoId("_s9Gd6N8OEe-NrtAAlrBEgQ")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : InstructionCancellationRequestStatus20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlCmpltd")]
        public required NoReasonCode Value { get; init; }
    }
}
