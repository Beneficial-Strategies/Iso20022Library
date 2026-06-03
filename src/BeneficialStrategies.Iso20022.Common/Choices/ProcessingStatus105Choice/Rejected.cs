// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice
{
    /// <summary>Specifies the rejected status.</summary>
    [IsoId("_u9CdQaodEfCG2_q2WT-90w")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus105Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionOrRepairStatus43Choice_ Value { get; init; }
    }
}
