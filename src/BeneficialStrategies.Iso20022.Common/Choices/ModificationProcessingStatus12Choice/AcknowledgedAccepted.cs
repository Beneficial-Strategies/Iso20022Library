// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice
{
    /// <summary>Instruction has been acknowledged by the account servicer.</summary>
    [IsoId("_rZrHVaohEfCG2_q2WT-90w")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ModificationProcessingStatus12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus23Choice_ Value { get; init; }
    }
}
