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
[IsoId("_6StW05NLEeWGlc8L7oPDIg")]
[DisplayName("Other Amounts")]
public partial record OtherAmounts38
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_6StW1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection58? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_6StW3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection58? ChargesFees { get; init; } 
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_6StW5ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection58? CountryNationalFederalTax { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_6StW7ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection58? TradeAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_6StW9ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection58? ExecutingBrokerAmount { get; init; } 
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_6StW_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection58? IssueDiscountAllowance { get; init; } 
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_6StXBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection58? PaymentLevyTax { get; init; } 
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_6StXDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection58? LocalTax { get; init; } 
    
    /// <summary>
    /// Local tax country specific.
    /// </summary>
    [IsoId("_6StXFZNLEeWGlc8L7oPDIg")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc")]
    public AmountAndDirection58? LocalTaxCountrySpecific { get; init; } 
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_6StXF5NLEeWGlc8L7oPDIg")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection58? LocalBrokerCommission { get; init; } 
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_6StXH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection58? Margin { get; init; } 
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_6StXJ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection58? Other { get; init; } 
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_6StXL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection58? RegulatoryAmount { get; init; } 
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_6StXN5NLEeWGlc8L7oPDIg")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection58? ShippingAmount { get; init; } 
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_6StXP5NLEeWGlc8L7oPDIg")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection58? SpecialConcession { get; init; } 
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_6StXR5NLEeWGlc8L7oPDIg")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection58? StampDuty { get; init; } 
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_6StXT5NLEeWGlc8L7oPDIg")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection58? StockExchangeTax { get; init; } 
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_6StXV5NLEeWGlc8L7oPDIg")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection58? TransferTax { get; init; } 
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_6StXX5NLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection58? TransactionTax { get; init; } 
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_6StXZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection58? ValueAddedTax { get; init; } 
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_6StXb5NLEeWGlc8L7oPDIg")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection58? WithholdingTax { get; init; } 
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_6StXd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection58? NetGainLoss { get; init; } 
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_6StXf5NLEeWGlc8L7oPDIg")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection58? ConsumptionTax { get; init; } 
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_6StXh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection58? AccruedCapitalisationAmount { get; init; } 
    
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_6StXj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection58? BookValue { get; init; } 
    
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_6StXl5NLEeWGlc8L7oPDIg")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection58? CollateralMonitorAmount { get; init; } 
    
    
    #nullable disable
    
}
