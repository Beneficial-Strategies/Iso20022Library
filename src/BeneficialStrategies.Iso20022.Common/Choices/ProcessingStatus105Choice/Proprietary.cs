// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice
{
    /// <summary>Specifies the proprietary status.</summary>
    [IsoId("_u9CdZaodEfCG2_q2WT-90w")]
    [DisplayName("Proprietary")]
    public record Proprietary : ProcessingStatus105Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
