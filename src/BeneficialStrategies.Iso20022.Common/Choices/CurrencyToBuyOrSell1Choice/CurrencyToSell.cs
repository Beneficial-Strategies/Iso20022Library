// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrencyToBuyOrSell1Choice
{
    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_QsvIM9p-Ed-ak6NoX_4Aeg_-894055934")]
    [DisplayName("Currency To Sell")]
    public partial record CurrencyToSell : CurrencyToBuyOrSell1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
        /// </summary>
        [IsoXmlTag("CcyToSell")]
        public required ActiveCurrencyCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
