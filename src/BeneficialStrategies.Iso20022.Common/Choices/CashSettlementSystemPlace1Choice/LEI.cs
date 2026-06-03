// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystemPlace1Choice
{
    /// <summary>Legal entity identification as an alternate identification for a place of safekeeping.</summary>
    [IsoId("_YKiTY5ZhEfCShM_qO0U4ig")]
    [DisplayName("LEI")]
    public record LEI : CashSettlementSystemPlace1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("LEI")]
        public required IsoLEIIdentifier Value { get; init; }
    }
}
