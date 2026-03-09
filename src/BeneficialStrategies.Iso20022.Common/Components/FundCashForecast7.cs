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
[IsoId("_7zt4EQdpEeSPHJIdUs1USg")]
[DisplayName("Fund Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashForecast7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundCashForecast7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundCashForecast7( System.String reqIdentification,DateAndDateTimeChoice_ reqTradeDateTime,FinancialInstrument9 reqFinancialInstrumentDetails,System.String reqExceptionalNetCashFlowIndicator )
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
    [IsoId("_8NmXtQdpEeSPHJIdUs1USg")]
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
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_8NmXtwdpEeSPHJIdUs1USg")]
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
    [IsoId("_8NmXuQdpEeSPHJIdUs1USg")]
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
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_8NmXuwdpEeSPHJIdUs1USg")]
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
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_8NmXvQdpEeSPHJIdUs1USg")]
    [DisplayName("Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNAV")]
    #endif
    [IsoXmlTag("TtlNAV")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_8NmXvwdpEeSPHJIdUs1USg")]
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
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_8NmXwQdpEeSPHJIdUs1USg")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_8NmXwwdpEeSPHJIdUs1USg")]
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
    [IsoId("_8NmXxQdpEeSPHJIdUs1USg")]
    [DisplayName("Total NAV Change Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNAVChngRate")]
    #endif
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TotalNAVChangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalNAVChangeRate { get; init; } 
    #else
    public System.Decimal? TotalNAVChangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_8NmXxwdpEeSPHJIdUs1USg")]
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
    [IsoId("_hqVBcQd2EeSPHJIdUs1USg")]
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
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_8NmXyQdpEeSPHJIdUs1USg")]
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
    /// Price per unit of the trade date.
    /// </summary>
    [IsoId("_ov-2gwdrEeSPHJIdUs1USg")]
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
    [IsoId("_ov-2hAdrEeSPHJIdUs1USg")]
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
    /// Net cash flow expressed as a percentage of the total NAV for the share class.
    /// </summary>
    [IsoId("_ov-2hQdrEeSPHJIdUs1USg")]
    [DisplayName("Percentage Of Share Class Total NAV")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfShrClssTtlNAV")]
    #endif
    [IsoXmlTag("PctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfShareClassTotalNAV { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfShareClassTotalNAV { get; init; } 
    #else
    public System.Decimal? PercentageOfShareClassTotalNAV { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_8NmXywdpEeSPHJIdUs1USg")]
    [DisplayName("Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInFcstDtls")]
    #endif
    [IsoXmlTag("CshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast6? CashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast6? CashInForecastDetails { get; init; } 
    #else
    public CashInForecast6? CashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_8NmXzQdpEeSPHJIdUs1USg")]
    [DisplayName("Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshOutFcstDtls")]
    #endif
    [IsoXmlTag("CshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast6? CashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast6? CashOutForecastDetails { get; init; } 
    #else
    public CashOutForecast6? CashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_8NmXzwdpEeSPHJIdUs1USg")]
    [DisplayName("Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshFcstDtls")]
    #endif
    [IsoXmlTag("NetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast4? NetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast4? NetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast4? NetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
