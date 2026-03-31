// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_STaLENp-Ed-ak6NoX_4Aeg_1354169516")]
[DisplayName("Other Amounts")]
public record OtherAmounts4
{
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_STaLEdp-Ed-ak6NoX_4Aeg_1062211778")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection9? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_STaLEtp-Ed-ak6NoX_4Aeg_65139425")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection9? ChargesFees { get; init; }

    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_STaLE9p-Ed-ak6NoX_4Aeg_-931932928")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection9? CountryNationalFederalTax { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_STaLFNp-Ed-ak6NoX_4Aeg_-1929005281")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection9? TradeAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_STaLFdp-Ed-ak6NoX_4Aeg_1368889662")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_STaLFtp-Ed-ak6NoX_4Aeg_371817309")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection9? IssueDiscountAllowance { get; init; }

    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_STaLF9p-Ed-ak6NoX_4Aeg_-625255044")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection9? PaymentLevyTax { get; init; }

    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_STaLGNp-Ed-ak6NoX_4Aeg_-1622327397")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection9? LocalTax { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_STaLGdp-Ed-ak6NoX_4Aeg_1675567546")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection9? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_STjVANp-Ed-ak6NoX_4Aeg_678495193")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection9? Margin { get; init; }

    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_STjVAdp-Ed-ak6NoX_4Aeg_-241538459")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection9? Other { get; init; }

    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_STjVAtp-Ed-ak6NoX_4Aeg_1444451443")]
    [DisplayName("Postage Amount")]
    [IsoXmlTag("PstgAmt")]
    public AmountAndDirection9? PostageAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_STjVA9p-Ed-ak6NoX_4Aeg_447379090")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection9? RegulatoryAmount { get; init; }

    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_STjVBNp-Ed-ak6NoX_4Aeg_-549693263")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection9? ShippingAmount { get; init; }

    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_STjVBdp-Ed-ak6NoX_4Aeg_-1546765616")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection9? SpecialConcession { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_STjVBtp-Ed-ak6NoX_4Aeg_1751129327")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection9? StampDuty { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_STjVB9p-Ed-ak6NoX_4Aeg_754056974")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection9? StockExchangeTax { get; init; }

    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_STjVCNp-Ed-ak6NoX_4Aeg_-243015379")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection9? TransferTax { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_STjVCdp-Ed-ak6NoX_4Aeg_-1240087732")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection9? TransactionTax { get; init; }

    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_STtGANp-Ed-ak6NoX_4Aeg_2057807211")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection9? ValueAddedTax { get; init; }

    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_STtGAdp-Ed-ak6NoX_4Aeg_1060734858")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection9? WithholdingTax { get; init; }

    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_STtGAtp-Ed-ak6NoX_4Aeg_63662505")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection9? NetGainLoss { get; init; }

    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_STtGA9p-Ed-ak6NoX_4Aeg_-933409848")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection9? ConsumptionTax { get; init; }

    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_STtGBNp-Ed-ak6NoX_4Aeg_-1930482201")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; }

    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_STtGBdp-Ed-ak6NoX_4Aeg_-1645375470")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection9? BookValue { get; init; }
}
