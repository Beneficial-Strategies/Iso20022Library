// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
[IsoId("_SjM6m9p-Ed-ak6NoX_4Aeg_-1373036480")]
[DisplayName("Fund Cash In Breakdown")]
public partial record FundCashInBreakdown2
{
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_SjM6nNp-Ed-ak6NoX_4Aeg_-1364728168")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_SjM6ndp-Ed-ak6NoX_4Aeg_-1364727995")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_SjWrkNp-Ed-ak6NoX_4Aeg_-1364727255")]
    [DisplayName("New Amount Indicator")]
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewAmountIndicator { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjWrkdp-Ed-ak6NoX_4Aeg_-1160974452")]
    [DisplayName("Investment Fund Transaction In Type")]
    [IsoXmlTag("InvstmtFndTxInTp")]
    public required InvestmentFundTransactionInType1Code InvestmentFundTransactionInType { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjWrktp-Ed-ak6NoX_4Aeg_-1118608528")]
    [DisplayName("Extended Investment Fund Transaction In Type")]
    [IsoXmlTag("XtndedInvstmtFndTxInTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedInvestmentFundTransactionInType { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_SjWrk9p-Ed-ak6NoX_4Aeg_1971493639")]
    [DisplayName("Original Order Quantity Type")]
    [IsoXmlTag("OrgnlOrdrQtyTp")]
    public required OrderQuantityType2Code OriginalOrderQuantityType { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_SjWrlNp-Ed-ak6NoX_4Aeg_-1850633433")]
    [DisplayName("Extended Original Order Quantity Type")]
    [IsoXmlTag("XtndedOrgnlOrdrQtyTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOriginalOrderQuantityType { get; init; } 
    
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SjWrldp-Ed-ak6NoX_4Aeg_1648566786")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge16? ChargeDetails { get; init; } 
    
    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_SjWrltp-Ed-ak6NoX_4Aeg_-1363801795")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission9? CommissionDetails { get; init; } 
    
    
    #nullable disable
    
}
