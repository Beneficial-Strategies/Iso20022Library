// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Quantity83Choice
{
    /// <summary>Specifies the network fee quantity.</summary>
    [IsoId("_aUJLkZZeEfCShM_qO0U4ig")]
    [DisplayName("Network Fee Quantity")]
    public record NetworkFeeQuantity : Quantity83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NtwkFeeQty")]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
