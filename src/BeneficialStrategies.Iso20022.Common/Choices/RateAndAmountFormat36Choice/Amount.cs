// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat36Choice
{
    /// <summary>
    /// The value is expressed as a currency and amount.
    /// </summary>
    [IsoId("_Uq59g3aCEeOzT_JN45r5OQ")]
    [DisplayName("Amount")]
    public partial record Amount : RateAndAmountFormat36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The currency in which this amount is measured.
        /// </summary>
        [IsoId("_L8ZcEp0gEeOo48XfssNw8w_Currency")]
        [DisplayName("Currency And 30 Amount _ Currency")]
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
