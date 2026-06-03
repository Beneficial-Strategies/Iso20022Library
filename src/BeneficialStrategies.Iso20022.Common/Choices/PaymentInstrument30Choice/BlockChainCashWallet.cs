// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Block chain cash wallet details.</summary>
    [IsoId("52588a6f-393b-4c5b-a387-2bb5211dbd24")]
    [DisplayName("Block Chain Cash Wallet")]
    public record BlockChainCashWallet : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet14 Value { get; init; }
    }
}
