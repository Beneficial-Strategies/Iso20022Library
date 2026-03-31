// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
[IsoId("_Sk15U9p-Ed-ak6NoX_4Aeg_904957651")]
[DisplayName("Cash In Forecast")]
public record CashInForecast3
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_Sk15VNp-Ed-ak6NoX_4Aeg_904958118")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_Sk15Vdp-Ed-ak6NoX_4Aeg_904958503")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_Sk15Vtp-Ed-ak6NoX_4Aeg_904958737")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the estimated cash flow in is exceptional.
    /// </summary>
    [IsoId("_Sk15V9p-Ed-ak6NoX_4Aeg_904959091")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; }

    /// <summary>
    /// Breakdown of cash in amounts, eg, by transaction and order type.
    /// </summary>
    [IsoId("_Sk15WNp-Ed-ak6NoX_4Aeg_904959478")]
    [DisplayName("Cash In Breakdown Details")]
    [IsoXmlTag("CshInBrkdwnDtls")]
    public ValueList<FundCashInBreakdown2> CashInBreakdownDetails { get; init; } = [];
}
