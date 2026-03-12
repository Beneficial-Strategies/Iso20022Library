// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat7Choice
{
    /// <summary>
    /// Specifies different formats for interest rate used for payment.
    /// </summary>
    [IsoId("_VV7UI0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public partial record RateTypeAndAmountAndRateStatus : InterestRateUsedForPaymentFormat7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_ViH9A0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType33Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_ViH9C0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_ViH9DUEIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus3Choice_? RateStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
