// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystem6Choice
{
    /// <summary>Cash settlement system expressed as an ISO 20022 code.</summary>
    [IsoId("_evTQ1ZZ1EfC2_67yGLymgA")]
    [DisplayName("Code")]
    public record Code : CashSettlementSystem6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CashSettlementSystem3Code Value { get; init; }
    }
}
