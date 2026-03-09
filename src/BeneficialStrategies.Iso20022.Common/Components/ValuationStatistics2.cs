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
[IsoId("_VZADBtp-Ed-ak6NoX_4Aeg_1063188298")]
[DisplayName("Valuation Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationStatistics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationStatistics2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationStatistics2( string reqCurrency,PriceType2 reqPriceTypeChangeBasis,PriceValue2 reqPriceChange )
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
    [IsoId("_VZADB9p-Ed-ak6NoX_4Aeg_1063188713")]
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
    [IsoId("_VZADCNp-Ed-ak6NoX_4Aeg_1063189091")]
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
    /// Change in price since the last valuation.
    /// </summary>
    [IsoId("_VZADCdp-Ed-ak6NoX_4Aeg_1063189133")]
    [DisplayName("Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricChng")]
    #endif
    [IsoXmlTag("PricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValue2 PriceChange { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValue2 PriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue2 PriceChange { get; init; } 
    #else
    public PriceValue2 PriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_VZADCtp-Ed-ak6NoX_4Aeg_1063189246")]
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
    [IsoId("_VZADC9p-Ed-ak6NoX_4Aeg_1897040847")]
    [DisplayName("By Predefined Time Periods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByPrdfndTmPrds")]
    #endif
    [IsoXmlTag("ByPrdfndTmPrds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsByPredefinedTimePeriods1? ByPredefinedTimePeriods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsByPredefinedTimePeriods1? ByPredefinedTimePeriods { get; init; } 
    #else
    public StatisticsByPredefinedTimePeriods1? ByPredefinedTimePeriods { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to price variations, expressed using user-defined periods.
    /// </summary>
    [IsoId("_VZJM8Np-Ed-ak6NoX_4Aeg_1063190202")]
    [DisplayName("By User Defined Time Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ByUsrDfndTmPrd")]
    #endif
    [IsoXmlTag("ByUsrDfndTmPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsByUserDefinedTimePeriod1? ByUserDefinedTimePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsByUserDefinedTimePeriod1? ByUserDefinedTimePeriod { get; init; } 
    #else
    public StatisticsByUserDefinedTimePeriod1? ByUserDefinedTimePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
