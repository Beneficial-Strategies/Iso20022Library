// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystemPlace1Choice
{
    /// <summary>Unique and unambiguous way to identify an organisation.</summary>
    [IsoId("_vRpY45ZhEfCShM_qO0U4ig")]
    [DisplayName("Any BIC")]
    public record AnyBIC : CashSettlementSystemPlace1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AnyBIC")]
        public required IsoAnyBICDec2014Identifier Value { get; init; }
    }
}
