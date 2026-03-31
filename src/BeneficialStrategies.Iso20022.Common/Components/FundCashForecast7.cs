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
[IsoId("_7zt4EQdpEeSPHJIdUs1USg")]
[DisplayName("Fund Cash Forecast")]
public record FundCashForecast7
{
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_8NmXtQdpEeSPHJIdUs1USg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_8NmXtwdpEeSPHJIdUs1USg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_8NmXuQdpEeSPHJIdUs1USg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_8NmXuwdpEeSPHJIdUs1USg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_8NmXvQdpEeSPHJIdUs1USg")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> TotalNAV { get; init; } = [];

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_8NmXvwdpEeSPHJIdUs1USg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> PreviousTotalNAV { get; init; } = [];

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_8NmXwQdpEeSPHJIdUs1USg")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_8NmXwwdpEeSPHJIdUs1USg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_8NmXxQdpEeSPHJIdUs1USg")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_8NmXxwdpEeSPHJIdUs1USg")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> InvestmentCurrency { get; init; } = [];

    /// <summary>
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    [IsoId("_hqVBcQd2EeSPHJIdUs1USg")]
    [DisplayName("Currency Status")]
    [IsoXmlTag("CcySts")]
    public CurrencyDesignation1? CurrencyStatus { get; init; }

    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_8NmXyQdpEeSPHJIdUs1USg")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Price per unit of the trade date.
    /// </summary>
    [IsoId("_ov-2gwdrEeSPHJIdUs1USg")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public UnitPrice19? Price { get; init; }

    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    [IsoId("_ov-2hAdrEeSPHJIdUs1USg")]
    [DisplayName("Foreign Exchange Rate")]
    [IsoXmlTag("FXRate")]
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; }

    /// <summary>
    /// Net cash flow expressed as a percentage of the total NAV for the share class.
    /// </summary>
    [IsoId("_ov-2hQdrEeSPHJIdUs1USg")]
    [DisplayName("Percentage Of Share Class Total NAV")]
    [IsoXmlTag("PctgOfShrClssTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfShareClassTotalNAV { get; init; }

    /// <summary>
    /// Cash movements into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_8NmXywdpEeSPHJIdUs1USg")]
    [DisplayName("Cash In Forecast Details")]
    [IsoXmlTag("CshInFcstDtls")]
    public ValueList<CashInForecast6> CashInForecastDetails { get; init; } = [];

    /// <summary>
    /// Cash movements out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_8NmXzQdpEeSPHJIdUs1USg")]
    [DisplayName("Cash Out Forecast Details")]
    [IsoXmlTag("CshOutFcstDtls")]
    public ValueList<CashOutForecast6> CashOutForecastDetails { get; init; } = [];

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_8NmXzwdpEeSPHJIdUs1USg")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public ValueList<NetCashForecast4> NetCashForecastDetails { get; init; } = [];
}
