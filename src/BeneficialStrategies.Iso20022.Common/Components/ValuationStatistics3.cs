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
[IsoId("_SeuqT9p-Ed-ak6NoX_4Aeg_578731261")]
[DisplayName("Valuation Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationStatistics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationStatistics3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationStatistics3( string reqCurrency,PriceType2 reqPriceTypeChangeBasis,PriceValueChange1 reqPriceChange )
    {
        Currency = reqCurrency;
        PriceTypeChangeBasis = reqPriceTypeChangeBasis;
        PriceChange = reqPriceChange;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the valuation statistics.
    /// </summary>
    [IsoId("_SeuqUNp-Ed-ak6NoX_4Aeg_578731305")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Type of price from which the change is calculated, eg, bid, offer, or single.
    /// </summary>
    [IsoId("_SeuqUdp-Ed-ak6NoX_4Aeg_578731364")]
    [DisplayName("Price Type Change Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTpChngBsis")]
    #endif
    [IsoXmlTag("PricTpChngBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceType2 PriceTypeChangeBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceType2 PriceTypeChangeBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceType2 PriceTypeChangeBasis { get; init; } 
    #else
    public PriceType2 PriceTypeChangeBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    [IsoId("_SeuqUtp-Ed-ak6NoX_4Aeg_578731434")]
    [DisplayName("Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricChng")]
    #endif
    [IsoXmlTag("PricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValueChange1 PriceChange { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValueChange1 PriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueChange1 PriceChange { get; init; } 
    #else
    public PriceValueChange1 PriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_Se4bQNp-Ed-ak6NoX_4Aeg_578731519")]
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
    
    /// <summary>
    /// Information related to price variations, expressed using pre-defined periods.
    /// </summary>
    [IsoId("_Se4bQdp-Ed-ak6NoX_4Aeg_578731849")]
    [DisplayName("By Predefined Time Periods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByPrdfndTmPrds")]
    #endif
    [IsoXmlTag("ByPrdfndTmPrds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; init; } 
    #else
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to price variations, expressed using user-defined periods.
    /// </summary>
    [IsoId("_Se4bQtp-Ed-ak6NoX_4Aeg_579651898")]
    [DisplayName("By User Defined Time Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByUsrDfndTmPrd")]
    #endif
    [IsoXmlTag("ByUsrDfndTmPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsByUserDefinedTimePeriod2? ByUserDefinedTimePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsByUserDefinedTimePeriod2? ByUserDefinedTimePeriod { get; init; } 
    #else
    public StatisticsByUserDefinedTimePeriod2? ByUserDefinedTimePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
