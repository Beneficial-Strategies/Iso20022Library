// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice
{
    /// <summary>Block chain cash wallet details.</summary>
    [IsoId("39c92d53-eb9e-4ebd-81bf-9ae1b3f7300c")]
    [DisplayName("Block Chain Cash Wallet")]
    public record BlockChainCashWallet : PaymentInstrument28Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet14 Value { get; init; }
    }
}
