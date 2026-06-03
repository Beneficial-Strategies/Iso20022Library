// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice
{
    /// <summary>Specifies the repair status.</summary>
    [IsoId("_u9CdTaodEfCG2_q2WT-90w")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus105Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rpr")]
        public required RejectionOrRepairStatus42Choice_ Value { get; init; }
    }
}
