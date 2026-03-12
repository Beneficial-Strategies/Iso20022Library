// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
[IsoId("_SjWrndp-Ed-ak6NoX_4Aeg_-222208527")]
[DisplayName("Fund Cash Forecast")]
public partial record FundCashForecast4
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_Sjf1gNp-Ed-ak6NoX_4Aeg_-99942813")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_Sjf1gdp-Ed-ak6NoX_4Aeg_-222208517")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_Sjf1gtp-Ed-ak6NoX_4Aeg_-222208483")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_Sjf1g9p-Ed-ak6NoX_4Aeg_-221287131")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_Sjf1hNp-Ed-ak6NoX_4Aeg_-222208466")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_Sjf1hdp-Ed-ak6NoX_4Aeg_-222208231")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_Sjf1htp-Ed-ak6NoX_4Aeg_-222208206")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SjpmgNp-Ed-ak6NoX_4Aeg_-222208189")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_Sjpmgdp-Ed-ak6NoX_4Aeg_-222208146")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_Sjpmgtp-Ed-ak6NoX_4Aeg_-222208129")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    
    /// <summary>
    /// Net cash movements per financial instrument.
    /// </summary>
    [IsoId("_Sjpmg9p-Ed-ak6NoX_4Aeg_-222207648")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public NetCashForecast2? NetCashForecastDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_SjpmhNp-Ed-ak6NoX_4Aeg_-222207786")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Cash flow by country.
    /// </summary>
    [IsoId("_Sjpmhdp-Ed-ak6NoX_4Aeg_-761081801")]
    [DisplayName("Breakdown By Country")]
    [IsoXmlTag("BrkdwnByCtry")]
    public BreakdownByCountry1? BreakdownByCountry { get; init; } 
    
    /// <summary>
    /// Cash flow by currency.
    /// </summary>
    [IsoId("_Sjpmhtp-Ed-ak6NoX_4Aeg_-755543099")]
    [DisplayName("Breakdown By Currency")]
    [IsoXmlTag("BrkdwnByCcy")]
    public BreakdownByCurrency1? BreakdownByCurrency { get; init; } 
    
    /// <summary>
    /// Cash flow by party.
    /// </summary>
    [IsoId("_Sjpmh9p-Ed-ak6NoX_4Aeg_243049335")]
    [DisplayName("Breakdown By Party")]
    [IsoXmlTag("BrkdwnByPty")]
    public BreakdownByParty1? BreakdownByParty { get; init; } 
    
    /// <summary>
    /// Cash flow by a user defined parameter/s.
    /// </summary>
    [IsoId("_SjpmiNp-Ed-ak6NoX_4Aeg_-745382905")]
    [DisplayName("Breakdown By User Defined Parameter")]
    [IsoXmlTag("BrkdwnByUsrDfndParam")]
    public BreakdownByUserDefinedParameter1? BreakdownByUserDefinedParameter { get; init; } 
    
    
    #nullable disable
    
}
