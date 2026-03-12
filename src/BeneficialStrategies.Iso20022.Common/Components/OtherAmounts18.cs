// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_sJD7Af_lEeCozs3wYX8fBQ")]
[DisplayName("Other Amounts")]
public partial record OtherAmounts18
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_sJD7C__lEeCozs3wYX8fBQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection9? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_sJD7Ff_lEeCozs3wYX8fBQ")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection9? ChargesFees { get; init; } 
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_sJD7H__lEeCozs3wYX8fBQ")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection9? CountryNationalFederalTax { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_sJD7Kf_lEeCozs3wYX8fBQ")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection9? TradeAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_sJD7M__lEeCozs3wYX8fBQ")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; } 
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_sJD7Pf_lEeCozs3wYX8fBQ")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection9? IssueDiscountAllowance { get; init; } 
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_sJD7R__lEeCozs3wYX8fBQ")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection9? PaymentLevyTax { get; init; } 
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_sJD7Uf_lEeCozs3wYX8fBQ")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection9? LocalTax { get; init; } 
    
    /// <summary>
    /// Local tax country specific.
    /// </summary>
    [IsoId("_sJD7W__lEeCozs3wYX8fBQ")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc")]
    public AmountAndDirection9? LocalTaxCountrySpecific { get; init; } 
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_sJD7X__lEeCozs3wYX8fBQ")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection9? LocalBrokerCommission { get; init; } 
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_sJD7af_lEeCozs3wYX8fBQ")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection9? Margin { get; init; } 
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_sJD7c__lEeCozs3wYX8fBQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection9? Other { get; init; } 
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_sJD7h__lEeCozs3wYX8fBQ")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection9? RegulatoryAmount { get; init; } 
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_sJD7kf_lEeCozs3wYX8fBQ")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection9? ShippingAmount { get; init; } 
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_sJD7m__lEeCozs3wYX8fBQ")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection9? SpecialConcession { get; init; } 
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_sJD7pf_lEeCozs3wYX8fBQ")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection9? StampDuty { get; init; } 
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_sJD7r__lEeCozs3wYX8fBQ")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection9? StockExchangeTax { get; init; } 
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_sJD7uf_lEeCozs3wYX8fBQ")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection9? TransferTax { get; init; } 
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_sJD7w__lEeCozs3wYX8fBQ")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection9? TransactionTax { get; init; } 
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_sJD7zf_lEeCozs3wYX8fBQ")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection9? ValueAddedTax { get; init; } 
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_sJD71__lEeCozs3wYX8fBQ")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection9? WithholdingTax { get; init; } 
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_sJD74f_lEeCozs3wYX8fBQ")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection9? NetGainLoss { get; init; } 
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_sJD76__lEeCozs3wYX8fBQ")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection9? ConsumptionTax { get; init; } 
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_sJD79f_lEeCozs3wYX8fBQ")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; } 
    
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_sJD7___lEeCozs3wYX8fBQ")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection9? BookValue { get; init; } 
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_sJD8Cf_lEeCozs3wYX8fBQ")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection9? CollateralMonitorAmount { get; init; } 
    
    
    #nullable disable
    
}
