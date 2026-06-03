// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Quantity83Choice
{
    /// <summary>Specifies the electronic money token settlement quantity.</summary>
    [IsoId("_YOu-QZZeEfCShM_qO0U4ig")]
    [DisplayName("Electronic Money Token Settlement Quantity")]
    public record ElectronicMoneyTokenSettlementQuantity : Quantity83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ElctrncMnyTknSttlmQty")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
