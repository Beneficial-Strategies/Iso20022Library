// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknownChoice
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_QaaCFtp-Ed-ak6NoX_4Aeg_1030711746")]
    [DisplayName("Amount")]
    public partial record Amount : PriceRateOrAmountOrUnknownChoice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_YYB_9Np-Ed-ak6NoX_4Aeg_-771372619_Currency")]
        [DisplayName("Active Or Historic Currency And 13 Decimal Amount _ Currency")]
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
