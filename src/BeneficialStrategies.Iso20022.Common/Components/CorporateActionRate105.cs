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
[IsoId("_YT-8Re29Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate105
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    [IsoId("_Yn6kFe29Eeqc-LCjwLsUVg")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat37Choice_? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat37Choice_? InterestRate { get; init; } 
    #else
    public RateAndAmountFormat37Choice_? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    [IsoId("_Yn6kHe29Eeqc-LCjwLsUVg")]
    [DisplayName("Percentage Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgSght")]
    #endif
    [IsoXmlTag("PctgSght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat7Choice_? PercentageSought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat7Choice_? PercentageSought { get; init; } 
    #else
    public RateFormat7Choice_? PercentageSought { get; set; } 
    #endif
    
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_Yn6kJe29Eeqc-LCjwLsUVg")]
    [DisplayName("Related Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdIndx")]
    #endif
    [IsoXmlTag("RltdIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? RelatedIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? RelatedIndex { get; init; } 
    #else
    public RateFormat3Choice_? RelatedIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_Yn6kLe29Eeqc-LCjwLsUVg")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? Spread { get; init; } 
    #else
    public RateFormat3Choice_? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_Yn6kNe29Eeqc-LCjwLsUVg")]
    [DisplayName("Bid Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidIntrvl")]
    #endif
    [IsoXmlTag("BidIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat38Choice_? BidInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat38Choice_? BidInterval { get; init; } 
    #else
    public RateAndAmountFormat38Choice_? BidInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_Yn6kPe29Eeqc-LCjwLsUVg")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat12Choice_? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat12Choice_? PreviousFactor { get; init; } 
    #else
    public RateFormat12Choice_? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_Yn6kRe29Eeqc-LCjwLsUVg")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat12Choice_? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat12Choice_? NextFactor { get; init; } 
    #else
    public RateFormat12Choice_? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_Yn6kTe29Eeqc-LCjwLsUVg")]
    [DisplayName("Reinvestment Discount Rate To Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDscntRateToMkt")]
    #endif
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; init; } 
    #else
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; set; } 
    #endif
    
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    [IsoId("_Yn6kVe29Eeqc-LCjwLsUVg")]
    [DisplayName("Interest Shortfall")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstShrtfll")]
    #endif
    [IsoXmlTag("IntrstShrtfll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat39Choice_? InterestShortfall { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat39Choice_? InterestShortfall { get; init; } 
    #else
    public RateAndAmountFormat39Choice_? InterestShortfall { get; set; } 
    #endif
    
    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    [IsoId("_Yn6kV-29Eeqc-LCjwLsUVg")]
    [DisplayName("Realised Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RealsdLoss")]
    #endif
    [IsoXmlTag("RealsdLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat39Choice_? RealisedLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat39Choice_? RealisedLoss { get; init; } 
    #else
    public RateAndAmountFormat39Choice_? RealisedLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    [IsoId("_Yn6kWe29Eeqc-LCjwLsUVg")]
    [DisplayName("Declared Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdRate")]
    #endif
    [IsoXmlTag("DclrdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat39Choice_? DeclaredRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat39Choice_? DeclaredRate { get; init; } 
    #else
    public RateAndAmountFormat39Choice_? DeclaredRate { get; set; } 
    #endif
    
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_brtFNO29Eeqc-LCjwLsUVg")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat37Choice_? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat37Choice_? IndexFactor { get; init; } 
    #else
    public RateAndAmountFormat37Choice_? IndexFactor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
