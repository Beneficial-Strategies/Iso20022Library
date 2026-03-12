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
[IsoId("_JSDipTbtEead9bDRE_1DAQ")]
[DisplayName("Fund Order Data")]
public partial record FundOrderData5
{
    #nullable enable
    
    /// <summary>
    /// Account information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_JrNCUTbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Financial instrument information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_JrNCUzbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Number of investment fund units subscribed or redeemed.
    /// </summary>
    [IsoId("_JrNCVTbtEead9bDRE_1DAQ")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? UnitsNumber { get; init; } 
    
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be invested in the fund. 
    /// Net Amount = Quantity * Price.
    /// When the status message is used for a redemption, this is the amount of money to be received following redemption of fund units. 
    /// Net Amount = (Quantity * Price) - (Fees + Taxes).
    /// </summary>
    [IsoId("_JrNCVzbtEead9bDRE_1DAQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be paid by the investor when subscribing to fund units. 
    /// Gross amount = (Quantity * Price) + (Fees + Taxes). 
    /// When the status message is used for a redemption, this is the amount of money to be redeemed from the fund. 
    /// Gross Amount = Quantity * Price.
    /// </summary>
    [IsoId("_JrNCWTbtEead9bDRE_1DAQ")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/fund class, that is redeemed.
    /// </summary>
    [IsoId("_JrNCWzbtEead9bDRE_1DAQ")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_JrWMQTbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_JrWMQzbtEead9bDRE_1DAQ")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_JrWMRTbtEead9bDRE_1DAQ")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveCurrencyCode? QuotedCurrency { get; init; } 
    
    
    #nullable disable
    
}
