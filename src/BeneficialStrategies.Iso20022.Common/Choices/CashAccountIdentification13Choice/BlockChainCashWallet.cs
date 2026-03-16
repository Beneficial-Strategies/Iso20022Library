// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification13Choice
{
    /// <summary>
    /// Block Chain Cash Wallet.
    /// </summary>
    [DisplayName("Block Chain Cash Wallet")]
    public partial record BlockChainCashWallet : CashAccountIdentification13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BlckChainCshWllt")]
        public required BlockChainAddressWallet11 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
