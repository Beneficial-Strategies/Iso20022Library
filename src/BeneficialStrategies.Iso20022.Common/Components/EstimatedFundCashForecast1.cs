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
[IsoId("_VCfni9p-Ed-ak6NoX_4Aeg_811516950")]
[DisplayName("Estimated Fund Cash Forecast")]
public record EstimatedFundCashForecast1
{
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_VCpYgNp-Ed-ak6NoX_4Aeg_811517010")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_VCpYgdp-Ed-ak6NoX_4Aeg_811517165")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_VCpYgtp-Ed-ak6NoX_4Aeg_811518062")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYg9p-Ed-ak6NoX_4Aeg_811517417")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; }

    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYhNp-Ed-ak6NoX_4Aeg_1066203354")]
    [DisplayName("Previous Estimated Total NAV")]
    [IsoXmlTag("PrvsEstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; init; }

    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VCpYhdp-Ed-ak6NoX_4Aeg_811517459")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCpYhtp-Ed-ak6NoX_4Aeg_1407903533")]
    [DisplayName("Previous Estimated Total Units Number")]
    [IsoXmlTag("PrvsEstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_VCpYh9p-Ed-ak6NoX_4Aeg_811517502")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_VCpYiNp-Ed-ak6NoX_4Aeg_811517572")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> InvestmentCurrency { get; init; } = [];

    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_VCyicNp-Ed-ak6NoX_4Aeg_811517537")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_VCyicdp-Ed-ak6NoX_4Aeg_811518002")]
    [DisplayName("Estimated Cash In Forecast Details")]
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    public ValueList<CashInForecast2> EstimatedCashInForecastDetails { get; init; } = [];

    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_VCyictp-Ed-ak6NoX_4Aeg_811517967")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    public ValueList<CashOutForecast2> EstimatedCashOutForecastDetails { get; init; } = [];

    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_VCyic9p-Ed-ak6NoX_4Aeg_811517907")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public ValueList<NetCashForecast1> EstimatedNetCashForecastDetails { get; init; } = [];
}
