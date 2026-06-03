// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus21Choice
{
    /// <summary>Provides status information related to a cancellation request accepted for further processing.</summary>
    [IsoId("_c8L7KaKvEfCHi7w3_0pcpw")]
    [DisplayName("Accepted")]
    public record Accepted : InstructionCancellationRequestStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Accptd")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
