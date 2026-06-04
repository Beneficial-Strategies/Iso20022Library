// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus34Choice
{
    /// <summary>Settlement status expressed as a failing status.</summary>
    [IsoId("_XtOZ--SkEe-qVZLXW4RRBw")]
    [DisplayName("Failing")]
    public record Failing : SettlementStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Flng")]
        public required FailingStatus17Choice_ Value { get; init; }
    }
}
