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
[IsoId("_VBTUtNp-Ed-ak6NoX_4Aeg_1030770482")]
[DisplayName("Fund Cash Forecast")]
public record FundCashForecast1
{
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_VBTUtdp-Ed-ak6NoX_4Aeg_1030770508")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_VBTUttp-Ed-ak6NoX_4Aeg_1030770931")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_VBTUt9p-Ed-ak6NoX_4Aeg_-325675847")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VBTUuNp-Ed-ak6NoX_4Aeg_1030770991")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VBTUudp-Ed-ak6NoX_4Aeg_-2046659078")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; }

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VBTUutp-Ed-ak6NoX_4Aeg_1030771034")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VBTUu9p-Ed-ak6NoX_4Aeg_-1958925001")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_VBdFsNp-Ed-ak6NoX_4Aeg_1030771317")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_VBdFsdp-Ed-ak6NoX_4Aeg_1030771394")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> InvestmentCurrency { get; init; } = [];

    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_VBdFstp-Ed-ak6NoX_4Aeg_1030771352")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_VBdFs9p-Ed-ak6NoX_4Aeg_-1419372801")]
    [DisplayName("Cash In Forecast Details")]
    [IsoXmlTag("CshInFcstDtls")]
    public ValueList<CashInForecast2> CashInForecastDetails { get; init; } = [];

    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_VBdFtNp-Ed-ak6NoX_4Aeg_-1360268388")]
    [DisplayName("Cash Out Forecast Details")]
    [IsoXmlTag("CshOutFcstDtls")]
    public ValueList<CashOutForecast2> CashOutForecastDetails { get; init; } = [];

    /// <summary>
    /// Cash movements from or to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_VBdFtdp-Ed-ak6NoX_4Aeg_1030771498")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public ValueList<NetCashForecast1> NetCashForecastDetails { get; init; } = [];
}
