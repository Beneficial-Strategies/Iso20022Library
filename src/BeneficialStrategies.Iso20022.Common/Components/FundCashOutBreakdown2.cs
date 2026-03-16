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
[IsoId("_SjDJlNp-Ed-ak6NoX_4Aeg_-2020690769")]
[DisplayName("Fund Cash Out Breakdown")]
public record FundCashOutBreakdown2
{
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_SjDJldp-Ed-ak6NoX_4Aeg_-2019770158")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_SjDJltp-Ed-ak6NoX_4Aeg_-2019769690")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_SjDJl9p-Ed-ak6NoX_4Aeg_-2019769305")]
    [DisplayName("New Amount Indicator")]
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewAmountIndicator { get; init; }

    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    [IsoId("_SjDJmNp-Ed-ak6NoX_4Aeg_881142863")]
    [DisplayName("Investment Fund Transaction Out Type")]
    [IsoXmlTag("InvstmtFndTxOutTp")]
    public required InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; init; }

    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    [IsoId("_SjM6kNp-Ed-ak6NoX_4Aeg_881142898")]
    [DisplayName("Extended Investment Fund Transaction Out Type")]
    [IsoXmlTag("XtndedInvstmtFndTxOutTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedInvestmentFundTransactionOutType { get; init; }

    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_SjM6kdp-Ed-ak6NoX_4Aeg_881143175")]
    [DisplayName("Original Order Quantity Type")]
    [IsoXmlTag("OrgnlOrdrQtyTp")]
    public required OrderQuantityType2Code OriginalOrderQuantityType { get; init; }

    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjM6ktp-Ed-ak6NoX_4Aeg_881143235")]
    [DisplayName("Extended Original Order Quantity Type")]
    [IsoXmlTag("XtndedOrgnlOrdrQtyTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOriginalOrderQuantityType { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SjM6k9p-Ed-ak6NoX_4Aeg_2117714463")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge16> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_SjM6lNp-Ed-ak6NoX_4Aeg_-2019767882")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission9> CommissionDetails { get; init; } = [];
}
