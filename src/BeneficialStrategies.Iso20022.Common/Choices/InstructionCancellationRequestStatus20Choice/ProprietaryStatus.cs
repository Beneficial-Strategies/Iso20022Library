// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus20Choice
{
    /// <summary>Proprietary status related to an instruction cancellation request.</summary>
    [IsoId("_s9Gd5t8OEe-NrtAAlrBEgQ")]
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : InstructionCancellationRequestStatus20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
