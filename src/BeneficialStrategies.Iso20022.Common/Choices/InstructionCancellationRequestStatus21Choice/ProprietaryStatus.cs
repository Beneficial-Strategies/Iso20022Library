// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus21Choice
{
    /// <summary>Proprietary status related to an instruction cancellation request.</summary>
    [IsoId("_c8L7QaKvEfCHi7w3_0pcpw")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : InstructionCancellationRequestStatus21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
