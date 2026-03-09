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
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("_Se4bTNp-Ed-ak6NoX_4Aeg_1006320598")]
[DisplayName("Statistics By User Defined Time Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsByUserDefinedTimePeriod2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatisticsByUserDefinedTimePeriod2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatisticsByUserDefinedTimePeriod2( DateOrDateTimePeriodChoice_ reqPeriod )
    {
        Period = reqPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    [IsoId("_Se4bTdp-Ed-ak6NoX_4Aeg_1006320633")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateOrDateTimePeriodChoice_ Period { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateOrDateTimePeriodChoice_ Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriodChoice_ Period { get; init; } 
    #else
    public DateOrDateTimePeriodChoice_ Period { get; set; } 
    #endif
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_Se4bTtp-Ed-ak6NoX_4Aeg_1006320710")]
    [DisplayName("Highest Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstPricVal")]
    #endif
    [IsoXmlTag("HghstPricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue5? HighestPriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue5? HighestPriceValue { get; init; } 
    #else
    public PriceValue5? HighestPriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_Se4bT9p-Ed-ak6NoX_4Aeg_1006320770")]
    [DisplayName("Lowest Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstPricVal")]
    #endif
    [IsoXmlTag("LwstPricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue5? LowestPriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue5? LowestPriceValue { get; init; } 
    #else
    public PriceValue5? LowestPriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    [IsoId("_SfCMQNp-Ed-ak6NoX_4Aeg_1006321065")]
    [DisplayName("Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricChng")]
    #endif
    [IsoXmlTag("PricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueChange1? PriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueChange1? PriceChange { get; init; } 
    #else
    public PriceValueChange1? PriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_SfCMQdp-Ed-ak6NoX_4Aeg_1006321142")]
    [DisplayName("Yield")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Yld")]
    #endif
    [IsoXmlTag("Yld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Yield { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Yield { get; init; } 
    #else
    public System.Decimal? Yield { get; set; } 
    #endif
    
    
    #nullable disable
    
}
