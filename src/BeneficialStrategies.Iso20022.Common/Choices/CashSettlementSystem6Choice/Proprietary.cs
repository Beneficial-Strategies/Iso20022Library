// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystem6Choice
{
    /// <summary>Cash settlement system expressed as a proprietary code.</summary>
    [IsoId("_evTQ4ZZ1EfC2_67yGLymgA")]
    [DisplayName("Proprietary")]
    public record Proprietary : CashSettlementSystem6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
