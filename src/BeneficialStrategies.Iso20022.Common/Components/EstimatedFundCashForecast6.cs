// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
[IsoId("_7dIg4QdlEeSPHJIdUs1USg")]
[DisplayName("Estimated Fund Cash Forecast")]
public record EstimatedFundCashForecast6
{
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_736YZQdlEeSPHJIdUs1USg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("_736YZwdlEeSPHJIdUs1USg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_736YaQdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_736YawdlEeSPHJIdUs1USg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YbQdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YbwdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; }

    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_736YcQdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_736YcwdlEeSPHJIdUs1USg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_736YdQdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_736YdwdlEeSPHJIdUs1USg")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; }

    /// <summary>
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    [IsoId("_ZDZIMAdzEeSPHJIdUs1USg")]
    [DisplayName("Currency Status")]
    [IsoXmlTag("CcySts")]
    public CurrencyDesignation1? CurrencyStatus { get; init; }

    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_736YeQdlEeSPHJIdUs1USg")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Price per unit of the previous trade date.
    /// </summary>
    [IsoId("_JX6ZsAdmEeSPHJIdUs1USg")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public UnitPrice19? Price { get; init; }

    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    [IsoId("_JX6ZsQdmEeSPHJIdUs1USg")]
    [DisplayName("Foreign Exchange Rate")]
    [IsoXmlTag("FXRate")]
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; }

    /// <summary>
    /// Estimated net cash flow expressed as a percentage of the previous total NAV for the share class.
    /// </summary>
    [IsoId("_JX6ZsgdmEeSPHJIdUs1USg")]
    [DisplayName("Estimated Percentage Of Share Class Total NAV")]
    [IsoXmlTag("EstmtdPctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedPercentageOfShareClassTotalNAV { get; init; }

    /// <summary>
    /// Estimated cash movements into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_736YewdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Cash In Forecast Details")]
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    public CashInForecast6? EstimatedCashInForecastDetails { get; init; }

    /// <summary>
    /// Estimated cash movements out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_736YfQdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    public CashOutForecast6? EstimatedCashOutForecastDetails { get; init; }

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_736YfwdlEeSPHJIdUs1USg")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; init; }
}
