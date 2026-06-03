// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus11Choice
{
    /// <summary>Instruction has been cancelled.</summary>
    [IsoId("247206ce-1281-402e-b82d-e82b0e394179")]
    [DisplayName("Cancelled")]
    public record Cancelled : IntraPositionProcessingStatus11Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus24Choice_ Value { get; init; }
    }
}
