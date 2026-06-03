// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification82Choice
{
    /// <summary>Digital account where digital assets or digital tokens can be stored and where an entry is made.</summary>
    [IsoId("a0cc3248-ac50-4dfb-bba0-516982d58ef2")]
    [DisplayName("Block Chain Cash Wallet")]
    public record BlockChainCashWallet : AccountIdentification82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet3 Value { get; init; }
    }
}
