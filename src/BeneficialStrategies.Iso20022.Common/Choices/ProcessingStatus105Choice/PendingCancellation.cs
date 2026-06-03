// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice
{
    /// <summary>Specifies the pending cancellation status.</summary>
    [IsoId("_u9CdNaodEfCG2_q2WT-90w")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus105Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus82Choice_ Value { get; init; }
    }
}
