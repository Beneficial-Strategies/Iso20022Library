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
[IsoId("_SjWrndp-Ed-ak6NoX_4Aeg_-222208527")]
[DisplayName("Fund Cash Forecast")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundCashForecast4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundCashForecast4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundCashForecast4( System.String reqIdentification,DateAndDateTimeChoice_ reqTradeDateTime,FinancialInstrument9 reqFinancialInstrumentDetails,System.String reqExceptionalNetCashFlowIndicator )
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
    [IsoId("_Sjf1gNp-Ed-ak6NoX_4Aeg_-99942813")]
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
    [IsoId("_Sjf1gdp-Ed-ak6NoX_4Aeg_-222208517")]
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
    [IsoId("_Sjf1gtp-Ed-ak6NoX_4Aeg_-222208483")]
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
    [IsoId("_Sjf1g9p-Ed-ak6NoX_4Aeg_-221287131")]
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
    [IsoId("_Sjf1hNp-Ed-ak6NoX_4Aeg_-222208466")]
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
    [IsoId("_Sjf1hdp-Ed-ak6NoX_4Aeg_-222208231")]
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
    [IsoId("_Sjf1htp-Ed-ak6NoX_4Aeg_-222208206")]
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
    [IsoId("_SjpmgNp-Ed-ak6NoX_4Aeg_-222208189")]
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
    [IsoId("_Sjpmgdp-Ed-ak6NoX_4Aeg_-222208146")]
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
    [IsoId("_Sjpmgtp-Ed-ak6NoX_4Aeg_-222208129")]
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
    /// Net cash movements per financial instrument.
    /// </summary>
    [IsoId("_Sjpmg9p-Ed-ak6NoX_4Aeg_-222207648")]
    [DisplayName("Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshFcstDtls")]
    #endif
    [IsoXmlTag("NetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast2? NetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast2? NetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast2? NetCashForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_SjpmhNp-Ed-ak6NoX_4Aeg_-222207786")]
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
    /// Cash flow by country.
    /// </summary>
    [IsoId("_Sjpmhdp-Ed-ak6NoX_4Aeg_-761081801")]
    [DisplayName("Breakdown By Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByCtry")]
    #endif
    [IsoXmlTag("BrkdwnByCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BreakdownByCountry1? BreakdownByCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BreakdownByCountry1? BreakdownByCountry { get; init; } 
    #else
    public BreakdownByCountry1? BreakdownByCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Cash flow by currency.
    /// </summary>
    [IsoId("_Sjpmhtp-Ed-ak6NoX_4Aeg_-755543099")]
    [DisplayName("Breakdown By Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByCcy")]
    #endif
    [IsoXmlTag("BrkdwnByCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BreakdownByCurrency1? BreakdownByCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BreakdownByCurrency1? BreakdownByCurrency { get; init; } 
    #else
    public BreakdownByCurrency1? BreakdownByCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Cash flow by party.
    /// </summary>
    [IsoId("_Sjpmh9p-Ed-ak6NoX_4Aeg_243049335")]
    [DisplayName("Breakdown By Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByPty")]
    #endif
    [IsoXmlTag("BrkdwnByPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BreakdownByParty1? BreakdownByParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BreakdownByParty1? BreakdownByParty { get; init; } 
    #else
    public BreakdownByParty1? BreakdownByParty { get; set; } 
    #endif
    
    /// <summary>
    /// Cash flow by a user defined parameter/s.
    /// </summary>
    [IsoId("_SjpmiNp-Ed-ak6NoX_4Aeg_-745382905")]
    [DisplayName("Breakdown By User Defined Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkdwnByUsrDfndParam")]
    #endif
    [IsoXmlTag("BrkdwnByUsrDfndParam")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BreakdownByUserDefinedParameter1? BreakdownByUserDefinedParameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BreakdownByUserDefinedParameter1? BreakdownByUserDefinedParameter { get; init; } 
    #else
    public BreakdownByUserDefinedParameter1? BreakdownByUserDefinedParameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
