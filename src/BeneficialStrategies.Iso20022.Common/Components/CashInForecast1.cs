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
[IsoId("_VCC7kdp-Ed-ak6NoX_4Aeg_542558277")]
[DisplayName("Cash In Forecast")]
public record CashInForecast1
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_VCC7ktp-Ed-ak6NoX_4Aeg_542558544")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_VCC7k9p-Ed-ak6NoX_4Aeg_542558620")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_VCC7lNp-Ed-ak6NoX_4Aeg_542558578")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the estimated cash flow in is exceptional.
    /// </summary>
    [IsoId("_VCC7ldp-Ed-ak6NoX_4Aeg_542558698")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; }

    /// <summary>
    /// Breakdown of cash in amounts, eg, by transaction and order type.
    /// </summary>
    [IsoId("_VCC7ltp-Ed-ak6NoX_4Aeg_-455150453")]
    [DisplayName("Cash In Breakdown Details")]
    [IsoXmlTag("CshInBrkdwnDtls")]
    public ValueList<FundCashInBreakdown1> CashInBreakdownDetails { get; init; } = [];
}
