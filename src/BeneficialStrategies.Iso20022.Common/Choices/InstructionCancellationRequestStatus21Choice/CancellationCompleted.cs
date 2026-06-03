// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus21Choice
{
    /// <summary>Provides status information related to an instruction cancellation request completed.</summary>
    [IsoId("_c8L7IaKvEfCHi7w3_0pcpw")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : InstructionCancellationRequestStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlCmpltd")]
        public required CancelledStatus11Choice_ Value { get; init; }
    }
}
