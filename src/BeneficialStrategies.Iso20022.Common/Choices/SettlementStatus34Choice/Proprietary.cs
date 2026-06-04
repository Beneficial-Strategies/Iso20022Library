// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus34Choice
{
    /// <summary>Settlement status expressed as a proprietary status and reason.</summary>
    [IsoId("_XtOaA-SkEe-qVZLXW4RRBw")]
    [DisplayName("Proprietary")]
    public record Proprietary : SettlementStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
