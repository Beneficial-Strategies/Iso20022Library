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
[IsoId("_SjzXgtp-Ed-ak6NoX_4Aeg_1861205426")]
[DisplayName("Fund Cash Forecast")]
public record FundCashForecast3
{
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_SjzXg9p-Ed-ak6NoX_4Aeg_-196910243")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_SjzXhNp-Ed-ak6NoX_4Aeg_1861206087")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_SjzXhdp-Ed-ak6NoX_4Aeg_1861206357")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_SjzXhtp-Ed-ak6NoX_4Aeg_1862127457")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SjzXh9p-Ed-ak6NoX_4Aeg_1861206382")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; }

    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SjzXiNp-Ed-ak6NoX_4Aeg_1861206442")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; }

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SjzXidp-Ed-ak6NoX_4Aeg_1861206459")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SjzXitp-Ed-ak6NoX_4Aeg_1862126543")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_Sj8hcNp-Ed-ak6NoX_4Aeg_1862126561")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_Sj8hcdp-Ed-ak6NoX_4Aeg_1862126621")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; }

    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_Sj8hctp-Ed-ak6NoX_4Aeg_1862126663")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; }

    /// <summary>
    /// Cash movements into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_Sj8hc9p-Ed-ak6NoX_4Aeg_1217473671")]
    [DisplayName("Cash In Forecast Details")]
    [IsoXmlTag("CshInFcstDtls")]
    public CashInForecast4? CashInForecastDetails { get; init; }

    /// <summary>
    /// Cash movements out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_Sj8hdNp-Ed-ak6NoX_4Aeg_2101282754")]
    [DisplayName("Cash Out Forecast Details")]
    [IsoXmlTag("CshOutFcstDtls")]
    public CashOutForecast4? CashOutForecastDetails { get; init; }

    /// <summary>
    /// Cash movements from or to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_Sj8hddp-Ed-ak6NoX_4Aeg_1862127423")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public NetCashForecast2? NetCashForecastDetails { get; init; }
}
