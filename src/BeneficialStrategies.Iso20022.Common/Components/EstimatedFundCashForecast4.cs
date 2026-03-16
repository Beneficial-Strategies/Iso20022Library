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
[IsoId("_Sj8hedp-Ed-ak6NoX_4Aeg_-271542988")]
[DisplayName("Estimated Fund Cash Forecast")]
public record EstimatedFundCashForecast4
{
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_Sj8hetp-Ed-ak6NoX_4Aeg_-72234288")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_Sj8he9p-Ed-ak6NoX_4Aeg_-271542918")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_SkGScNp-Ed-ak6NoX_4Aeg_-271542616")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_SkGScdp-Ed-ak6NoX_4Aeg_-270620083")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkGSctp-Ed-ak6NoX_4Aeg_-271542238")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkGSc9p-Ed-ak6NoX_4Aeg_-271542142")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; }

    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SkGSdNp-Ed-ak6NoX_4Aeg_-271542082")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkGSddp-Ed-ak6NoX_4Aeg_-271542005")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Estimated cash flow by party.
    /// </summary>
    [IsoId("_SkGSdtp-Ed-ak6NoX_4Aeg_1392936682")]
    [DisplayName("Breakdown By Party")]
    [IsoXmlTag("BrkdwnByPty")]
    public ValueList<BreakdownByParty1> BreakdownByParty { get; init; } = [];

    /// <summary>
    /// Estimated cash flow by country.
    /// </summary>
    [IsoId("_SkGSd9p-Ed-ak6NoX_4Aeg_1473281612")]
    [DisplayName("Breakdown By Country")]
    [IsoXmlTag("BrkdwnByCtry")]
    public ValueList<BreakdownByCountry1> BreakdownByCountry { get; init; } = [];

    /// <summary>
    /// Estimated cash flow by currency.
    /// </summary>
    [IsoId("_SkGSeNp-Ed-ak6NoX_4Aeg_1573945036")]
    [DisplayName("Breakdown By Currency")]
    [IsoXmlTag("BrkdwnByCcy")]
    public ValueList<BreakdownByCurrency1> BreakdownByCurrency { get; init; } = [];

    /// <summary>
    /// Estimated cash flow by a user defined parameter/s.
    /// </summary>
    [IsoId("_SkPcYNp-Ed-ak6NoX_4Aeg_1619196494")]
    [DisplayName("Breakdown By User Defined Parameter")]
    [IsoXmlTag("BrkdwnByUsrDfndParam")]
    public ValueList<BreakdownByUserDefinedParameter1> BreakdownByUserDefinedParameter { get; init; } =
        [];

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_SkPcYdp-Ed-ak6NoX_4Aeg_-271541710")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_SkPcYtp-Ed-ak6NoX_4Aeg_-271541615")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> InvestmentCurrency { get; init; } = [];

    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_SkPcY9p-Ed-ak6NoX_4Aeg_-270621541")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Estimated net cash movements per financial instrument.
    /// </summary>
    [IsoId("_SkPcZNp-Ed-ak6NoX_4Aeg_-270621384")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public ValueList<NetCashForecast2> EstimatedNetCashForecastDetails { get; init; } = [];
}
