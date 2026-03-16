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
[IsoId("_I7Gg_QatEeS3lpTattq7hg")]
[DisplayName("Fund Cash Out Breakdown")]
public record FundCashOutBreakdown3
{
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_JVSilwatEeS3lpTattq7hg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_JVSimQatEeS3lpTattq7hg")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, for example, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_JVSimwatEeS3lpTattq7hg")]
    [DisplayName("New Amount Indicator")]
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewAmountIndicator { get; init; }

    /// <summary>
    /// Type of transaction that resulted in the cash-out movement, for example, redemption, switch-out.
    /// </summary>
    [IsoId("_QzutQAaxEeS3lpTattq7hg")]
    [DisplayName("Investment Fund Transaction Out Type")]
    [IsoXmlTag("InvstmtFndTxOutTp")]
    public required InvestmentFundTransactionOutType1Choice_ InvestmentFundTransactionOutType { get; init; }

    /// <summary>
    /// Specifies how the original order was expressed that resulted in the cash-out movement, that is cash or units.
    /// </summary>
    [IsoId("_w86QMAaxEeS3lpTattq7hg")]
    [DisplayName("Original Order Quantity Type")]
    [IsoXmlTag("OrgnlOrdrQtyTp")]
    public required QuantityType1Choice_ OriginalOrderQuantityType { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_JVSipQatEeS3lpTattq7hg")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge26? ChargeDetails { get; init; }

    /// <summary>
    /// Information related to the commission applied to an order, for example, back-end or front-end commission.
    /// </summary>
    [IsoId("_JVSipwatEeS3lpTattq7hg")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission21? CommissionDetails { get; init; }

    /// <summary>
    /// Settlement currency for the transaction.
    /// </summary>
    [IsoId("_iNcFdAc9EeSyIPzOZ6VzBQ")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }
}
