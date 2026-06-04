// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountIdentification1Choice
{
    /// <summary>Account identified by a blockchain address or wallet.</summary>
    [IsoId("_s5w_Sd-5Ee-Ned3-G07x_A")]
    [DisplayName("Block Chain Address Or Wallet")]
    public record BlockChainAddressOrWallet : SecuritiesAccountIdentification1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BlckChainAdrOrWllt")]
        public required IsoMax140Text Value { get; init; }
    }
}
