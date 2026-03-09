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
[IsoId("_VZJM-tp-Ed-ak6NoX_4Aeg_16395281")]
[DisplayName("Statistics By User Defined Time Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsByUserDefinedTimePeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatisticsByUserDefinedTimePeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatisticsByUserDefinedTimePeriod1( DateTimePeriodDetails reqPeriod )
    {
        Period = reqPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    [IsoId("_VZJM-9p-Ed-ak6NoX_4Aeg_93973909")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateTimePeriodDetails Period { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateTimePeriodDetails Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriodDetails Period { get; init; } 
    #else
    public DateTimePeriodDetails Period { get; set; } 
    #endif
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_VZJM_Np-Ed-ak6NoX_4Aeg_123524743")]
    [DisplayName("Highest Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghstPricVal")]
    #endif
    [IsoXmlTag("HghstPricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? HighestPriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? HighestPriceValue { get; init; } 
    #else
    public PriceValue1? HighestPriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_VZJM_dp-Ed-ak6NoX_4Aeg_138301510")]
    [DisplayName("Lowest Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwstPricVal")]
    #endif
    [IsoXmlTag("LwstPricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? LowestPriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? LowestPriceValue { get; init; } 
    #else
    public PriceValue1? LowestPriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price since the last valuation.
    /// </summary>
    [IsoId("_VZJM_tp-Ed-ak6NoX_4Aeg_-1933750767")]
    [DisplayName("Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricChng")]
    #endif
    [IsoXmlTag("PricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue2? PriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue2? PriceChange { get; init; } 
    #else
    public PriceValue2? PriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_VZJM_9p-Ed-ak6NoX_4Aeg_1815898632")]
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
