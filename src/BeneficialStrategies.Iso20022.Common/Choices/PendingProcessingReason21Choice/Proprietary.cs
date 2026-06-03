// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason21Choice
{
    /// <summary>Specifies the reason why the instruction has a pending processing status.</summary>
    [IsoId("_XoK6gaobEfCG2_q2WT-90w")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingProcessingReason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
