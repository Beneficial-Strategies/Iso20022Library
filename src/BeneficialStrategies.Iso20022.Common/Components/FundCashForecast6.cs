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
[IsoId("_MJUJhQatEeS3lpTattq7hg")]
[DisplayName("Fund Cash Forecast")]
public partial record FundCashForecast6
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_MjNQFQatEeS3lpTattq7hg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_MjNQFwatEeS3lpTattq7hg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_MjNQGQatEeS3lpTattq7hg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_MjNQGwatEeS3lpTattq7hg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_MjNQHQatEeS3lpTattq7hg")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_MjNQHwatEeS3lpTattq7hg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_MjNQIQatEeS3lpTattq7hg")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_MjNQIwatEeS3lpTattq7hg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_MjNQJQatEeS3lpTattq7hg")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_MjNQJwatEeS3lpTattq7hg")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    
    /// <summary>
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    [IsoId("_a9bEkQd2EeSPHJIdUs1USg")]
    [DisplayName("Currency Status")]
    [IsoXmlTag("CcySts")]
    public CurrencyDesignation1? CurrencyStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_MjNQKwatEeS3lpTattq7hg")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Price per unit of the trade date.
    /// </summary>
    [IsoId("_-7pAYwdrEeSPHJIdUs1USg")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public UnitPrice19? Price { get; init; } 
    
    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    [IsoId("_-7pAZAdrEeSPHJIdUs1USg")]
    [DisplayName("Foreign Exchange Rate")]
    [IsoXmlTag("FXRate")]
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; } 
    
    /// <summary>
    /// Net cash flow expressed as a percentage of the total NAV for the share class.
    /// </summary>
    [IsoId("_-7pAZQdrEeSPHJIdUs1USg")]
    [DisplayName("Percentage Of Share Class Total NAV")]
    [IsoXmlTag("PctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfShareClassTotalNAV { get; init; } 
    
    /// <summary>
    /// Cash flow by party.
    /// </summary>
    [IsoId("_MjNQMQatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Party")]
    [IsoXmlTag("BrkdwnByPty")]
    public BreakdownByParty3? BreakdownByParty { get; init; } 
    
    /// <summary>
    /// Cash flow by country.
    /// </summary>
    [IsoId("_MjNQLQatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Country")]
    [IsoXmlTag("BrkdwnByCtry")]
    public BreakdownByCountry2? BreakdownByCountry { get; init; } 
    
    /// <summary>
    /// Cash flow by currency.
    /// </summary>
    [IsoId("_MjNQLwatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Currency")]
    [IsoXmlTag("BrkdwnByCcy")]
    public BreakdownByCurrency2? BreakdownByCurrency { get; init; } 
    
    /// <summary>
    /// Cash flow by a user defined parameter/s.
    /// </summary>
    [IsoId("_MjNQMwatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By User Defined Parameter")]
    [IsoXmlTag("BrkdwnByUsrDfndParam")]
    public BreakdownByUserDefinedParameter3? BreakdownByUserDefinedParameter { get; init; } 
    
    /// <summary>
    /// Net cash movements per financial instrument.
    /// </summary>
    [IsoId("_MjNQKQatEeS3lpTattq7hg")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public NetCashForecast4? NetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
