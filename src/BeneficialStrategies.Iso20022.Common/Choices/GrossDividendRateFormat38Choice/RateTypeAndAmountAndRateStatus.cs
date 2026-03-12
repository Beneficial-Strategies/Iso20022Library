// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat38Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_ahHhPeXsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public partial record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat38Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_ZfXJQeXsEemEj48jhmlA0Q")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType78Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_ZfXJSeXsEemEj48jhmlA0Q")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_ZfXJS-XsEemEj48jhmlA0Q")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
