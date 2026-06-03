// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus20Choice
{
    /// <summary>Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.</summary>
    [IsoId("_s9Gd6d8OEe-NrtAAlrBEgQ")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionCancellationRequestStatus20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus62Choice_ Value { get; init; }
    }
}
