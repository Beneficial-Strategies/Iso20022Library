// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition43Choice
{
    /// <summary>Settlement transaction condition expressed as a proprietary code.</summary>
    [IsoId("_hcLV2fHSEfChCaiL9q1LKg")]
    [DisplayName("Proprietary")]
    public record Proprietary : SettlementTransactionCondition43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
