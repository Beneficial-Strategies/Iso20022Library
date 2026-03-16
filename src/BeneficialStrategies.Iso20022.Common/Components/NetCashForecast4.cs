// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net cash movement to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_rVJXMQdFEeSyIPzOZ6VzBQ")]
[DisplayName("Net Cash Forecast")]
public record NetCashForecast4
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_rvLn0wdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; }

    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_rvLn1QdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_rvLn1wdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Net Units Number")]
    [IsoXmlTag("NetUnitsNb")]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; }

    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_rvLn2QdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Flow Direction")]
    [IsoXmlTag("FlowDrctn")]
    public required FlowDirectionType1Code FlowDirection { get; init; }

    /// <summary>
    /// Additional balances for cash amounts and number of units.
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    [IsoId("_utUz8QdFEeSyIPzOZ6VzBQ")]
    [DisplayName("Additional Balance")]
    [IsoXmlTag("AddtlBal")]
    public FundBalance1? AdditionalBalance { get; init; }
}
