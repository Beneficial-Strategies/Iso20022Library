// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType40Choice
{
    /// <summary>Update expressed as a modification of settlement transaction details.</summary>
    [IsoId("_Y7zw0ZaMEfC2_67yGLymgA")]
    [DisplayName("Modification")]
    public record Modification : UpdateType40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Mod")]
        public required SecuritiesSettlementTransactionDetails61 Value { get; init; }
    }
}
