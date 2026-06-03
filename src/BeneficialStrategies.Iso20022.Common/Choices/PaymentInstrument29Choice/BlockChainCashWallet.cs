// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Block chain cash wallet details.</summary>
    [IsoId("a6c011de-385d-4544-aab9-6213aaff0bcc")]
    [DisplayName("Block Chain Cash Wallet")]
    public record BlockChainCashWallet : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet14 Value { get; init; }
    }
}
