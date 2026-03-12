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
[IsoId("_VBwAo9p-Ed-ak6NoX_4Aeg_-855958594")]
[DisplayName("Fund Cash In Breakdown")]
public partial record FundCashInBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_VBwApNp-Ed-ak6NoX_4Aeg_-578901921")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_VBwApdp-Ed-ak6NoX_4Aeg_-871053048")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    [IsoId("_VBwAptp-Ed-ak6NoX_4Aeg_-566898010")]
    [DisplayName("New Amount Indicator")]
    [IsoXmlTag("NewAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewAmountIndicator { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    [IsoId("_VBwAp9p-Ed-ak6NoX_4Aeg_358470141")]
    [DisplayName("Investment Fund Transaction In Type Details")]
    [IsoXmlTag("InvstmtFndTxInTpDtls")]
    public InvestmentFundTransactionInType1? InvestmentFundTransactionInTypeDetails { get; init; } 
    
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    [IsoId("_VBwAqNp-Ed-ak6NoX_4Aeg_31543655")]
    [DisplayName("Original Order Quantity Details")]
    [IsoXmlTag("OrgnlOrdrQtyDtls")]
    public OriginalOrderQuantityType1? OriginalOrderQuantityDetails { get; init; } 
    
    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    [IsoId("_VBwAqdp-Ed-ak6NoX_4Aeg_257394767")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission4? CommissionDetails { get; init; } 
    
    
    #nullable disable
    
}
