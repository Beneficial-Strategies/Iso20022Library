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
[IsoId("_SkPcaNp-Ed-ak6NoX_4Aeg_-913330105")]
[DisplayName("Estimated Fund Cash Forecast")]
public partial record EstimatedFundCashForecast3
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_SkPcadp-Ed-ak6NoX_4Aeg_-53764956")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_SkPcatp-Ed-ak6NoX_4Aeg_-913330088")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_SkZNYNp-Ed-ak6NoX_4Aeg_-912409529")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [IsoId("_SkZNYdp-Ed-ak6NoX_4Aeg_-912407703")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkZNYtp-Ed-ak6NoX_4Aeg_-912409512")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkZNY9p-Ed-ak6NoX_4Aeg_-912409192")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SkZNZNp-Ed-ak6NoX_4Aeg_-912409175")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SkZNZdp-Ed-ak6NoX_4Aeg_-912409121")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_SkZNZtp-Ed-ak6NoX_4Aeg_-912409096")]
    [DisplayName("Estimated Total NAV Change Rate")]
    [IsoXmlTag("EstmtdTtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_SkZNZ9p-Ed-ak6NoX_4Aeg_-912408633")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [IsoId("_SkZNaNp-Ed-ak6NoX_4Aeg_-912408616")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Estimated cash movements into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_Ski-YNp-Ed-ak6NoX_4Aeg_-912407797")]
    [DisplayName("Estimated Cash In Forecast Details")]
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    public CashInForecast4? EstimatedCashInForecastDetails { get; init; } 
    
    /// <summary>
    /// Estimated cash movements out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_Ski-Ydp-Ed-ak6NoX_4Aeg_-912407780")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    public CashOutForecast4? EstimatedCashOutForecastDetails { get; init; } 
    
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_Ski-Ytp-Ed-ak6NoX_4Aeg_-912407642")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast2? EstimatedNetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
