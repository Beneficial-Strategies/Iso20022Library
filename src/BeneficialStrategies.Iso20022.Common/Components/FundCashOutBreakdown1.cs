// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_VBwAqtp-Ed-ak6NoX_4Aeg_-1800161519")]
[DisplayName("Fund Cash Out Breakdown")]
public record FundCashOutBreakdown1
{
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_VB5xoNp-Ed-ak6NoX_4Aeg_-1260826368")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_VB5xodp-Ed-ak6NoX_4Aeg_-724212157")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_VB5xotp-Ed-ak6NoX_4Aeg_-1534527424")]
    [DisplayName("New Amount Indicator")]
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewAmountIndicator { get; init; }

    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    [IsoId("_VB5xo9p-Ed-ak6NoX_4Aeg_-540871792")]
    [DisplayName("Investment Fund Transaction Out Type Details")]
    [IsoXmlTag("InvstmtFndTxOutTpDtls")]
    public InvestmentFundTransactionOutType1? InvestmentFundTransactionOutTypeDetails { get; init; }

    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_VB5xpNp-Ed-ak6NoX_4Aeg_-925979586")]
    [DisplayName("Original Order Quantity Details")]
    [IsoXmlTag("OrgnlOrdrQtyDtls")]
    public OriginalOrderQuantityType1? OriginalOrderQuantityDetails { get; init; }

    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_VB5xpdp-Ed-ak6NoX_4Aeg_1237784504")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission4? CommissionDetails { get; init; }
}
