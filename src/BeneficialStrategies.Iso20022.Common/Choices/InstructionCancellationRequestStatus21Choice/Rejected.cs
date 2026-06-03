// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus21Choice
{
    /// <summary>Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.</summary>
    [IsoId("_c8L7MaKvEfCHi7w3_0pcpw")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionCancellationRequestStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus65Choice_ Value { get; init; }
    }
}
