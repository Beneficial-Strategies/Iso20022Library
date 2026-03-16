// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_SksIUNp-Ed-ak6NoX_4Aeg_1915292616")]
[DisplayName("Cash Out Forecast")]
public record CashOutForecast3
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SksIUdp-Ed-ak6NoX_4Aeg_1916213081")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_SksIUtp-Ed-ak6NoX_4Aeg_1916213151")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_SksIU9p-Ed-ak6NoX_4Aeg_1916213565")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the estimated cash flow out is exceptional.
    /// </summary>
    [IsoId("_SksIVNp-Ed-ak6NoX_4Aeg_1916214941")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; }

    /// <summary>
    /// Breakdown of cash out amounts, eg, by transaction or order type.
    /// </summary>
    [IsoId("_SksIVdp-Ed-ak6NoX_4Aeg_1916216157")]
    [DisplayName("Cash Out Breakdown Details")]
    [IsoXmlTag("CshOutBrkdwnDtls")]
    public FundCashOutBreakdown2? CashOutBreakdownDetails { get; init; }
}
