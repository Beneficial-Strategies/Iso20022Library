// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
[IsoId("_TZcmGdp-Ed-ak6NoX_4Aeg_-1920684142")]
[DisplayName("Corporate Action Rate")]
public partial record CorporateActionRate3
{
    #nullable enable
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_TZcmGtp-Ed-ak6NoX_4Aeg_-1920683717")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public RateAndAmountFormat3Choice_? Interest { get; init; } 
    
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_TZcmG9p-Ed-ak6NoX_4Aeg_-1920683254")]
    [DisplayName("Percentage Sought")]
    [IsoXmlTag("PctgSght")]
    public RateFormat5Choice_? PercentageSought { get; init; } 
    
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_TZcmHNp-Ed-ak6NoX_4Aeg_-1920682745")]
    [DisplayName("Related Index")]
    [IsoXmlTag("RltdIndx")]
    public RateFormat2Choice_? RelatedIndex { get; init; } 
    
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_TZlwANp-Ed-ak6NoX_4Aeg_-1920682685")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public RateFormat2Choice_? Spread { get; init; } 
    
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_TZlwAdp-Ed-ak6NoX_4Aeg_-1920684081")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat3Choice_? BidInterval { get; init; } 
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_TZlwAtp-Ed-ak6NoX_4Aeg_-1535576396")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat3Choice_? PreviousFactor { get; init; } 
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_TZlwA9p-Ed-ak6NoX_4Aeg_-1417363832")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat3Choice_? NextFactor { get; init; } 
    
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_TZlwBNp-Ed-ak6NoX_4Aeg_1322853946")]
    [DisplayName("Reinvestment Discount Rate To Market")]
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    public RateFormat2Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    
    
    #nullable disable
    
}
