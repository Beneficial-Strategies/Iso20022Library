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
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
[IsoId("_VCfni9p-Ed-ak6NoX_4Aeg_811516950")]
[DisplayName("Estimated Fund Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EstimatedFundCashForecast1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EstimatedFundCashForecast1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EstimatedFundCashForecast1( DateAndDateTimeChoice_ reqTradeDateTime,DateAndDateTimeChoice_ reqPreviousTradeDateTime,FinancialInstrument5 reqFinancialInstrumentDetails,System.String reqExceptionalNetCashFlowIndicator )
    {
        TradeDateTime = reqTradeDateTime;
        PreviousTradeDateTime = reqPreviousTradeDateTime;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        ExceptionalNetCashFlowIndicator = reqExceptionalNetCashFlowIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_VCpYgNp-Ed-ak6NoX_4Aeg_811517010")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_VCpYgdp-Ed-ak6NoX_4Aeg_811517165")]
    [DisplayName("Previous Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTradDtTm")]
    #endif
    [IsoXmlTag("PrvsTradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ PreviousTradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_VCpYgtp-Ed-ak6NoX_4Aeg_811518062")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument5 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYg9p-Ed-ak6NoX_4Aeg_811517417")]
    [DisplayName("Estimated Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTtlNAV")]
    #endif
    [IsoXmlTag("EstmtdTtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYhNp-Ed-ak6NoX_4Aeg_1066203354")]
    [DisplayName("Previous Estimated Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsEstmtdTtlNAV")]
    #endif
    [IsoXmlTag("PrvsEstmtdTtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VCpYhdp-Ed-ak6NoX_4Aeg_811517459")]
    [DisplayName("Estimated Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTtlUnitsNb")]
    #endif
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYhtp-Ed-ak6NoX_4Aeg_1407903533")]
    [DisplayName("Previous Estimated Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsEstmtdTtlUnitsNb")]
    #endif
    [IsoXmlTag("PrvsEstmtdTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_VCpYh9p-Ed-ak6NoX_4Aeg_811517502")]
    [DisplayName("Estimated Total NAV Change Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTtlNAVChngRate")]
    #endif
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EstimatedTotalNAVChangeRate { get; init; } 
    #else
    public System.Decimal? EstimatedTotalNAVChangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_VCpYiNp-Ed-ak6NoX_4Aeg_811517572")]
    [DisplayName("Investment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtCcy")]
    #endif
    [IsoXmlTag("InvstmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InvestmentCurrency { get; init; } 
    #else
    public string? InvestmentCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_VCyicNp-Ed-ak6NoX_4Aeg_811517537")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcptnlNetCshFlowInd")]
    #endif
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExceptionalNetCashFlowIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExceptionalNetCashFlowIndicator { get; init; } 
    #else
    public System.String ExceptionalNetCashFlowIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_VCyicdp-Ed-ak6NoX_4Aeg_811518002")]
    [DisplayName("Estimated Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshInFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast2? EstimatedCashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast2? EstimatedCashInForecastDetails { get; init; } 
    #else
    public CashInForecast2? EstimatedCashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_VCyictp-Ed-ak6NoX_4Aeg_811517967")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshOutFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast2? EstimatedCashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast2? EstimatedCashOutForecastDetails { get; init; } 
    #else
    public CashOutForecast2? EstimatedCashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_VCyic9p-Ed-ak6NoX_4Aeg_811517907")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdNetCshFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
