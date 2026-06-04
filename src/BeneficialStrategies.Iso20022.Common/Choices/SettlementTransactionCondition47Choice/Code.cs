// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition47Choice
{
    /// <summary>Settlement transaction condition expressed as an ISO 20022 code.</summary>
    [IsoId("_m1cVBfHcEfChCaiL9q1LKg")]
    [DisplayName("Code")]
    public record Code : SettlementTransactionCondition47Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required SettlementTransactionCondition21Code Value { get; init; }
    }
}
