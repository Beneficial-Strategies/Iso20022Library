// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat1Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_UO8Dptp-Ed-ak6NoX_4Aeg_876664787")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    public partial record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_UOySqtp-Ed-ak6NoX_4Aeg_1884555210")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required RateType13Choice_ RateType { get; init; } 
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UOySq9p-Ed-ak6NoX_4Aeg_1140790877")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_UO8DoNp-Ed-ak6NoX_4Aeg_-983901934")]
        [DisplayName("Rate Status")]
        [IsoXmlTag("RateSts")]
        public RateStatus1Choice_? RateStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
