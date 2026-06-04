// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus34Choice
{
    /// <summary>Settlement status expressed as a pending status.</summary>
    [IsoId("_XtOZ8-SkEe-qVZLXW4RRBw")]
    [DisplayName("Pending")]
    public record Pending : SettlementStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus79Choice_ Value { get; init; }
    }
}
