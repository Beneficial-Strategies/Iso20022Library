// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity44Choice
{
    /// <summary>
    /// Cash amount to be transferred.
    /// </summary>
    [IsoId("_ZMtfME3WEeidB49bWZiS0g")]
    [DisplayName("Cash Amount")]
    public partial record CashAmount : Quantity44Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Currency")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoId("_YX4O9Np-Ed-ak6NoX_4Aeg_-184934550_Amount")]
        [DisplayName("Active Currency And 13 Decimal Amount _ Amount")]
        [IsoXmlTag("Amount")]
        public required System.Decimal Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
