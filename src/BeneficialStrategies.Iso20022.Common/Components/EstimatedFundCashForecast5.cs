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
[IsoId("_LvukuwatEeS3lpTattq7hg")]
[DisplayName("Estimated Fund Cash Forecast")]
public partial record EstimatedFundCashForecast5
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_MJUJZQatEeS3lpTattq7hg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("_MJUJZwatEeS3lpTattq7hg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_MJUJaQatEeS3lpTattq7hg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_MJUJawatEeS3lpTattq7hg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_MJUJbQatEeS3lpTattq7hg")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_MJUJbwatEeS3lpTattq7hg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_MJUJcQatEeS3lpTattq7hg")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_MJUJcwatEeS3lpTattq7hg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_MJUJfQatEeS3lpTattq7hg")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_MJUJfwatEeS3lpTattq7hg")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    
    /// <summary>
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    [IsoId("_ZEdX0Qd2EeSPHJIdUs1USg")]
    [DisplayName("Currency Status")]
    [IsoXmlTag("CcySts")]
    public CurrencyDesignation1? CurrencyStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_MJUJgQatEeS3lpTattq7hg")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Price per unit of the previous trade date.
    /// </summary>
    [IsoId("_7smyAQc-EeSyIPzOZ6VzBQ")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public UnitPrice19? Price { get; init; } 
    
    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    [IsoId("_RAETIQdAEeSyIPzOZ6VzBQ")]
    [DisplayName("Foreign Exchange Rate")]
    [IsoXmlTag("FXRate")]
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; } 
    
    /// <summary>
    /// Estimated net cash flow expressed as a percentage of the previous total NAV for the share class.
    /// </summary>
    [IsoId("_LR22UQdEEeSyIPzOZ6VzBQ")]
    [DisplayName("Estimated Percentage Of Share Class Total NAV")]
    [IsoXmlTag("EstmtdPctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedPercentageOfShareClassTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated cash flow by party.
    /// </summary>
    [IsoId("_MJUJdQatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Party")]
    [IsoXmlTag("BrkdwnByPty")]
    public BreakdownByParty3? BreakdownByParty { get; init; } 
    
    /// <summary>
    /// Estimated cash flow by country.
    /// </summary>
    [IsoId("_MJUJdwatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Country")]
    [IsoXmlTag("BrkdwnByCtry")]
    public BreakdownByCountry2? BreakdownByCountry { get; init; } 
    
    /// <summary>
    /// Estimated cash flow by currency.
    /// </summary>
    [IsoId("_MJUJeQatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By Currency")]
    [IsoXmlTag("BrkdwnByCcy")]
    public BreakdownByCurrency2? BreakdownByCurrency { get; init; } 
    
    /// <summary>
    /// Estimated cash flow by a user defined parameter/s.
    /// </summary>
    [IsoId("_MJUJewatEeS3lpTattq7hg")]
    [DisplayName("Breakdown By User Defined Parameter")]
    [IsoXmlTag("BrkdwnByUsrDfndParam")]
    public BreakdownByUserDefinedParameter3? BreakdownByUserDefinedParameter { get; init; } 
    
    /// <summary>
    /// Estimated net cash movements per financial instrument.
    /// </summary>
    [IsoId("_MJUJgwatEeS3lpTattq7hg")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
