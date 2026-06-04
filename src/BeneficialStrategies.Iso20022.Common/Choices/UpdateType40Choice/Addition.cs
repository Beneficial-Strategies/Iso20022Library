// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType40Choice
{
    /// <summary>Update expressed as an addition of settlement transaction details.</summary>
    [IsoId("_Y7zwxZaMEfC2_67yGLymgA")]
    [DisplayName("Addition")]
    public record Addition : UpdateType40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Addtn")]
        public required SecuritiesSettlementTransactionDetails59 Value { get; init; }
    }
}
