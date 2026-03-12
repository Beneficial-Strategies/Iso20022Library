// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknown3Choice
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_gdOxm833Eee5nJBZsW8MFQ")]
    [DisplayName("Amount")]
    public partial record Amount : PriceRateOrAmountOrUnknown3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_WOMlp9p-Ed-ak6NoX_4Aeg_-1678737059_Currency")]
        [DisplayName("Restricted FIN Active Or Historic Currency And 13 Decimal Amount _ Currency")]
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
