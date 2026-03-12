// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extract of trade data for an investment fund order.
/// </summary>
[IsoId("_TRinQtp-Ed-ak6NoX_4Aeg_1770817650")]
[DisplayName("Fund Order Data")]
public partial record FundOrderData1
{
    #nullable enable
    
    /// <summary>
    /// Account information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_TRinQ9p-Ed-ak6NoX_4Aeg_1031732513")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Financial instrument information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_TRinRNp-Ed-ak6NoX_4Aeg_1033581402")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Quantity of investment fund units subscribed or redeemed.
    /// </summary>
    [IsoId("_TRinRdp-Ed-ak6NoX_4Aeg_1770818005")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold or subscribed to.
    /// </summary>
    [IsoId("_TRinRtp-Ed-ak6NoX_4Aeg_1770818022")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold or subscribed to, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_TRinR9p-Ed-ak6NoX_4Aeg_1771738071")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_TRinSNp-Ed-ak6NoX_4Aeg_1771738054")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_TRsYQNp-Ed-ak6NoX_4Aeg_-1994354495")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_TRsYQdp-Ed-ak6NoX_4Aeg_-1020963799")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_TRsYQtp-Ed-ak6NoX_4Aeg_-1020963764")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveOrHistoricCurrencyCode? QuotedCurrency { get; init; } 
    
    
    #nullable disable
    
}
