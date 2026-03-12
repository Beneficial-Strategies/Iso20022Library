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
[IsoId("_VBdFudp-Ed-ak6NoX_4Aeg_386757279")]
[DisplayName("Fund Cash Forecast")]
public partial record FundCashForecast2
{
    #nullable enable
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [IsoId("_VBdFutp-Ed-ak6NoX_4Aeg_386757321")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("_VBdFu9p-Ed-ak6NoX_4Aeg_386757581")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    [IsoId("_VBmPoNp-Ed-ak6NoX_4Aeg_63125019")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VBmPodp-Ed-ak6NoX_4Aeg_386757616")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    
    /// <summary>
    /// Previous value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_VBmPotp-Ed-ak6NoX_4Aeg_-2116187889")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VBmPo9p-Ed-ak6NoX_4Aeg_386757651")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_VBmPpNp-Ed-ak6NoX_4Aeg_-2112495850")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [IsoId("_VBmPpdp-Ed-ak6NoX_4Aeg_386757693")]
    [DisplayName("Total NAV Change Rate")]
    [IsoXmlTag("TtlNAVChngRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TotalNAVChangeRate { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_VBmPptp-Ed-ak6NoX_4Aeg_386758019")]
    [DisplayName("Investment Currency")]
    [IsoXmlTag("InvstmtCcy")]
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the net cash flow is exceptional.
    /// </summary>
    [IsoId("_VBmPp9p-Ed-ak6NoX_4Aeg_386757984")]
    [DisplayName("Exceptional Net Cash Flow Indicator")]
    [IsoXmlTag("XcptnlNetCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Information related to the cash movements reported by pre-defined or user defined criteria.
    /// </summary>
    [IsoId("_VBmPqNp-Ed-ak6NoX_4Aeg_386758081")]
    [DisplayName("Sorting Criteria Details")]
    [IsoXmlTag("SrtgCritDtls")]
    public ValueList<CashSortingCriterion2> SortingCriteriaDetails { get; init; } = new ValueList<CashSortingCriterion2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VBmPqNp-Ed-ak6NoX_4Aeg_386758081
    
    /// <summary>
    /// Net cash movements per financial instrument.
    /// </summary>
    [IsoId("_VBmPqdp-Ed-ak6NoX_4Aeg_1702783920")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public NetCashForecast1? NetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
