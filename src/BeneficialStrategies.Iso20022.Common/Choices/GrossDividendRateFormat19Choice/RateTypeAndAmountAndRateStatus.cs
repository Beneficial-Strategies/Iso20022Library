// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat19Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_xsyFO2OUEeWYYI9c62RCjw")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public partial record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat19Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_MjGzk0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType40Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_MjGzm0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_MjGznUEIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
