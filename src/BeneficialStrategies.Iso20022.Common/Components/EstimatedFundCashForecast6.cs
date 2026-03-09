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
[IsoId("_7dIg4QdlEeSPHJIdUs1USg")]
[DisplayName("Estimated Fund Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EstimatedFundCashForecast6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EstimatedFundCashForecast6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EstimatedFundCashForecast6( System.String reqIdentification,DateAndDateTimeChoice_ reqTradeDateTime,FinancialInstrument9 reqFinancialInstrumentDetails,System.String reqExceptionalNetCashFlowIndicator )
    {
        Identification = reqIdentification;
        TradeDateTime = reqTradeDateTime;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        ExceptionalNetCashFlowIndicator = reqExceptionalNetCashFlowIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_736YZQdlEeSPHJIdUs1USg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("_736YZwdlEeSPHJIdUs1USg")]
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
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_736YaQdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTradDtTm")]
    #endif
    [IsoXmlTag("PrvsTradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_736YawdlEeSPHJIdUs1USg")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument9 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YbQdlEeSPHJIdUs1USg")]
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
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YbwdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlNAV")]
    #endif
    [IsoXmlTag("PrvsTtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_736YcQdlEeSPHJIdUs1USg")]
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
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YcwdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsTtlUnitsNb")]
    #endif
    [IsoXmlTag("PrvsTtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_736YdQdlEeSPHJIdUs1USg")]
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
    [IsoId("_736YdwdlEeSPHJIdUs1USg")]
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
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    [IsoId("_ZDZIMAdzEeSPHJIdUs1USg")]
    [DisplayName("Currency Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcySts")]
    #endif
    [IsoXmlTag("CcySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyDesignation1? CurrencyStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDesignation1? CurrencyStatus { get; init; } 
    #else
    public CurrencyDesignation1? CurrencyStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_736YeQdlEeSPHJIdUs1USg")]
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
    /// Price per unit of the previous trade date.
    /// </summary>
    [IsoId("_JX6ZsAdmEeSPHJIdUs1USg")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitPrice19? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPrice19? Price { get; init; } 
    #else
    public UnitPrice19? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    [IsoId("_JX6ZsQdmEeSPHJIdUs1USg")]
    [DisplayName("Foreign Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXRate")]
    #endif
    [IsoXmlTag("FXRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; } 
    #else
    public ForeignExchangeTerms19? ForeignExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated net cash flow expressed as a percentage of the previous total NAV for the share class.
    /// </summary>
    [IsoId("_JX6ZsgdmEeSPHJIdUs1USg")]
    [DisplayName("Estimated Percentage Of Share Class Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdPctgOfShrClssTtlNAV")]
    #endif
    [IsoXmlTag("EstmtdPctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? EstimatedPercentageOfShareClassTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EstimatedPercentageOfShareClassTotalNAV { get; init; } 
    #else
    public System.Decimal? EstimatedPercentageOfShareClassTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated cash movements into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_736YewdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshInFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast6? EstimatedCashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast6? EstimatedCashInForecastDetails { get; init; } 
    #else
    public CashInForecast6? EstimatedCashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated cash movements out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_736YfQdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshOutFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast6? EstimatedCashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast6? EstimatedCashOutForecastDetails { get; init; } 
    #else
    public CashOutForecast6? EstimatedCashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_736YfwdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdNetCshFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
