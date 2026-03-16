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
[IsoId("_VCWdldp-Ed-ak6NoX_4Aeg_-373893977")]
[DisplayName("Estimated Fund Cash Forecast")]
public record EstimatedFundCashForecast2
{
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_VCWdltp-Ed-ak6NoX_4Aeg_-373893958")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_VCWdl9p-Ed-ak6NoX_4Aeg_-373893924")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_VCWdmNp-Ed-ak6NoX_4Aeg_-373893388")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCWdmdp-Ed-ak6NoX_4Aeg_-373893882")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; }

    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCfngNp-Ed-ak6NoX_4Aeg_860915375")]
    [DisplayName("Previous Estimated Total NAV")]
    [IsoXmlTag("PrvsEstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; init; }

    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VCfngdp-Ed-ak6NoX_4Aeg_-373893839")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous estimated value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VCfngtp-Ed-ak6NoX_4Aeg_865532857")]
    [DisplayName("Previous Estimated Total Units Number")]
    [IsoXmlTag("PrvsEstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_VCfng9p-Ed-ak6NoX_4Aeg_-373893804")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_VCfnhNp-Ed-ak6NoX_4Aeg_-373893727")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; }

    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_VCfnhdp-Ed-ak6NoX_4Aeg_-373893769")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Information related to the estimated cash movements reported by pre-defined or user defined criteria.
    /// </summary>
    [IsoId("_VCfnhtp-Ed-ak6NoX_4Aeg_-373893431")]
    [DisplayName("Sorting Criteria Details")]
    [IsoXmlTag("SrtgCritDtls")]
    public ValueList<CashSortingCriterion1> SortingCriteriaDetails { get; init; } = [];

    // ID for the above is _VCfnhtp-Ed-ak6NoX_4Aeg_-373893431

    /// <summary>
    /// Net cash movements per financial instrument.
    /// </summary>
    [IsoId("_VCfnh9p-Ed-ak6NoX_4Aeg_-1924210004")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; }
}
