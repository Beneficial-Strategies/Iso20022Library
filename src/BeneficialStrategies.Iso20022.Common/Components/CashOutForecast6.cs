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
[IsoId("_Eh20QQdnEeSPHJIdUs1USg")]
[DisplayName("Cash Out Forecast")]
public record CashOutForecast6
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_E8C14wdnEeSPHJIdUs1USg")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_E8C15QdnEeSPHJIdUs1USg")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_E8C15wdnEeSPHJIdUs1USg")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the cash flow out is exceptional.
    /// </summary>
    [IsoId("_E8C16QdnEeSPHJIdUs1USg")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; }

    /// <summary>
    /// Additional balances for cash amounts and number of units.
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    [IsoId("_P07D8QdnEeSPHJIdUs1USg")]
    [DisplayName("Additional Balance")]
    [IsoXmlTag("AddtlBal")]
    public FundBalance1? AdditionalBalance { get; init; }
}
