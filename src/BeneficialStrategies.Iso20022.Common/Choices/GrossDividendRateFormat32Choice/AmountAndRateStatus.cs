// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat32Choice
{
    /// <summary>
    /// Specifies an amount and a rate status.
    /// </summary>
    [IsoId("_sk1grc3wEee5nJBZsW8MFQ")]
    [DisplayName("Amount And Rate Status")]
    public partial record AmountAndRateStatus : GrossDividendRateFormat32Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_g2FhhZnREeWLs7cvLxlyAg")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_g2FhhJnREeWLs7cvLxlyAg")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public required RateStatus1Code RateStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
