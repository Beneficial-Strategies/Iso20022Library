// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification10Choice
{
    /// <summary>
    /// Block Chain Cash Wallet.
    /// </summary>
    [DisplayName("Block Chain Cash Wallet")]
    public record BlockChainCashWallet : CashAccountIdentification10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet11 Value { get; init; }
    }
}
