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
/// Specifies rates.
/// </summary>
[IsoId("_Tf2JBdp-Ed-ak6NoX_4Aeg_-1452767156")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate1
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
    [IsoId("_Tf2JBtp-Ed-ak6NoX_4Aeg_-2054958770")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? Interest { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_Tf2JB9p-Ed-ak6NoX_4Aeg_-1563128851")]
    [DisplayName("Related Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdIndx")]
    #endif
    [IsoXmlTag("RltdIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? RelatedIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? RelatedIndex { get; init; } 
    #else
    public RateFormat1Choice_? RelatedIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_Tf2JCNp-Ed-ak6NoX_4Aeg_-2024233567")]
    [DisplayName("Percentage Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgSght")]
    #endif
    [IsoXmlTag("PctgSght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? PercentageSought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? PercentageSought { get; init; } 
    #else
    public RateFormat1Choice_? PercentageSought { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_Tf_6ANp-Ed-ak6NoX_4Aeg_-613289454")]
    [DisplayName("Reinvestment Discount To Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDscntToMkt")]
    #endif
    [IsoXmlTag("RinvstmtDscntToMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? ReinvestmentDiscountToMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? ReinvestmentDiscountToMarket { get; init; } 
    #else
    public RateFormat1Choice_? ReinvestmentDiscountToMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_Tf_6Adp-Ed-ak6NoX_4Aeg_377917731")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat1Choice_? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat1Choice_? Spread { get; init; } 
    #else
    public RateFormat1Choice_? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_Tf_6Atp-Ed-ak6NoX_4Aeg_440695672")]
    [DisplayName("Bid Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidIntrvl")]
    #endif
    [IsoXmlTag("BidIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndRateFormat3Choice_? BidInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndRateFormat3Choice_? BidInterval { get; init; } 
    #else
    public AmountAndRateFormat3Choice_? BidInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_Tf_6A9p-Ed-ak6NoX_4Aeg_-733274509")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat1Choice_? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_? Charges { get; init; } 
    #else
    public RateAndAmountFormat1Choice_? Charges { get; set; } 
    #endif
    
    
    #nullable disable
    
}
