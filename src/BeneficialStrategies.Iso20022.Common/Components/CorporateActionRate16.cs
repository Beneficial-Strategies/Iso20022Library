// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
[IsoId("_oME3YeGYEd-1Ktb5rVaajw")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_oME3Y-GYEd-1Ktb5rVaajw")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? Interest { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_oME3ZeGYEd-1Ktb5rVaajw")]
    [DisplayName("Percentage Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgSght")]
    #endif
    [IsoXmlTag("PctgSght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat5Choice_? PercentageSought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat5Choice_? PercentageSought { get; init; } 
    #else
    public RateFormat5Choice_? PercentageSought { get; set; } 
    #endif
    
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_oME3Z-GYEd-1Ktb5rVaajw")]
    [DisplayName("Related Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdIndx")]
    #endif
    [IsoXmlTag("RltdIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? RelatedIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? RelatedIndex { get; init; } 
    #else
    public RateFormat6Choice_? RelatedIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_oME3aeGYEd-1Ktb5rVaajw")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? Spread { get; init; } 
    #else
    public RateFormat6Choice_? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_oME3a-GYEd-1Ktb5rVaajw")]
    [DisplayName("Bid Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidIntrvl")]
    #endif
    [IsoXmlTag("BidIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat14Choice_? BidInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat14Choice_? BidInterval { get; init; } 
    #else
    public RateAndAmountFormat14Choice_? BidInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_oME3beGYEd-1Ktb5rVaajw")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? PreviousFactor { get; init; } 
    #else
    public RateFormat3Choice_? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_oME3b-GYEd-1Ktb5rVaajw")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? NextFactor { get; init; } 
    #else
    public RateFormat3Choice_? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_oME3ceGYEd-1Ktb5rVaajw")]
    [DisplayName("Reinvestment Discount Rate To Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDscntRateToMkt")]
    #endif
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    #else
    public RateFormat6Choice_? ReinvestmentDiscountRateToMarket { get; set; } 
    #endif
    
    
    #nullable disable
    
}
