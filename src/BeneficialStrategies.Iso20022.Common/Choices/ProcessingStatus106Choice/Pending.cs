// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus106Choice
{
    /// <summary>Specifies the pending status.</summary>
    [IsoId("_lrsGaaogEfCG2_q2WT-90w")]
    [DisplayName("Pending")]
    public record Pending : ProcessingStatus106Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus83Choice_ Value { get; init; }
    }
}
