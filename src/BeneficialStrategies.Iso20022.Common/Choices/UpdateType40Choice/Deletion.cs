// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType40Choice
{
    /// <summary>Update expressed as a deletion of settlement transaction details.</summary>
    [IsoId("_Y7zwy5aMEfC2_67yGLymgA")]
    [DisplayName("Deletion")]
    public record Deletion : UpdateType40Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Deltn")]
        public required SecuritiesSettlementTransactionDetails60 Value { get; init; }
    }
}
