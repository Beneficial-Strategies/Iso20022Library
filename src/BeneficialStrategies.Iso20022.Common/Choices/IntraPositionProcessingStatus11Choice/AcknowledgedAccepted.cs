// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus11Choice
{
    /// <summary>Instruction has been acknowledged by the account servicer.</summary>
    [IsoId("6e7836d7-4a5d-4abc-b810-e1598cb8ea1b")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : IntraPositionProcessingStatus11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus34Choice_ Value { get; init; }
    }
}
