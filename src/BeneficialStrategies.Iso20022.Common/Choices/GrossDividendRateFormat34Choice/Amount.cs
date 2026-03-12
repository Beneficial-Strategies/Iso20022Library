// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat34Choice
{
    /// <summary>
    /// Number of monetary units specified in a currency.
    /// </summary>
    [IsoId("_k9v_Gc3xEee5nJBZsW8MFQ")]
    [DisplayName("Amount")]
    public partial record Amount : GrossDividendRateFormat34Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WN5Dptp-Ed-ak6NoX_4Aeg_-154812387_Currency")]
        [DisplayName("Restricted FIN Active Currency And 13 Decimal Amount _ Currency")]
        [IsoXmlTag("Currency")]
        public required System.String Currency { get; init; } 
        
        /// <summary>
        /// Amount of the transaction.
        /// </summary>
        [IsoXmlTag("Amount")]
        public required System.Decimal Value { get; init; } 
        
        
        #nullable disable
        
    }
}
