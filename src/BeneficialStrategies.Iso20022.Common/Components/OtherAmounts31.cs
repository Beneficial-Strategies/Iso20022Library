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
[IsoId("_ugYp8Tp8EeWVrPy0StzzSg")]
[DisplayName("Other Amounts")]
public partial record OtherAmounts31
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_u_Uoszp8EeWVrPy0StzzSg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection44? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_u_Uouzp8EeWVrPy0StzzSg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection44? ChargesFees { get; init; } 
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_u_Uowzp8EeWVrPy0StzzSg")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection44? CountryNationalFederalTax { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_u_Uoyzp8EeWVrPy0StzzSg")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection44? TradeAmount { get; init; } 
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_u_Uo0zp8EeWVrPy0StzzSg")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection44? ExecutingBrokerAmount { get; init; } 
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_u_Uo2zp8EeWVrPy0StzzSg")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection44? IssueDiscountAllowance { get; init; } 
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_u_Uo4zp8EeWVrPy0StzzSg")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection44? PaymentLevyTax { get; init; } 
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_u_Uo6zp8EeWVrPy0StzzSg")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection44? LocalTax { get; init; } 
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_u_Uo8zp8EeWVrPy0StzzSg")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection44? LocalBrokerCommission { get; init; } 
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_u_Uo-zp8EeWVrPy0StzzSg")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection44? Margin { get; init; } 
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_u_UpAzp8EeWVrPy0StzzSg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection44? Other { get; init; } 
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_u_UpCzp8EeWVrPy0StzzSg")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection44? RegulatoryAmount { get; init; } 
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_u_UpEzp8EeWVrPy0StzzSg")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection44? ShippingAmount { get; init; } 
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_u_UpGzp8EeWVrPy0StzzSg")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection44? SpecialConcession { get; init; } 
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_u_UpIzp8EeWVrPy0StzzSg")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection44? StampDuty { get; init; } 
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_u_UpKzp8EeWVrPy0StzzSg")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection44? StockExchangeTax { get; init; } 
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_u_UpMzp8EeWVrPy0StzzSg")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection44? TransferTax { get; init; } 
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_u_UpOzp8EeWVrPy0StzzSg")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection44? TransactionTax { get; init; } 
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_u_UpQzp8EeWVrPy0StzzSg")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection44? ValueAddedTax { get; init; } 
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_u_UpSzp8EeWVrPy0StzzSg")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection44? WithholdingTax { get; init; } 
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_u_UpUzp8EeWVrPy0StzzSg")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection44? NetGainLoss { get; init; } 
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_u_UpWzp8EeWVrPy0StzzSg")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection44? ConsumptionTax { get; init; } 
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_u_UpYzp8EeWVrPy0StzzSg")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection44? AccruedCapitalisationAmount { get; init; } 
    
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_u_Upazp8EeWVrPy0StzzSg")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection44? BookValue { get; init; } 
    
    
    #nullable disable
    
}
