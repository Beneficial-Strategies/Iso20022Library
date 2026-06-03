// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice
{
    /// <summary>Instruction has been acknowledged by the account servicer.</summary>
    [IsoId("a46a7be4-a83e-4ad7-8a3c-a9f1ecc43be4")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ModificationProcessingStatus13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus23Choice_ Value { get; init; }
    }
}
