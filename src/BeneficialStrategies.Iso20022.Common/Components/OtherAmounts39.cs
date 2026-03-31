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
[IsoId("_BNURwaz_EeeBVbuVcoH9Nw")]
[DisplayName("Other Amounts")]
public record OtherAmounts39
{
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_BYLd8az_EeeBVbuVcoH9Nw")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection44? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_BYLd86z_EeeBVbuVcoH9Nw")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection44? ChargesFees { get; init; }

    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_BYLd9az_EeeBVbuVcoH9Nw")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection44? CountryNationalFederalTax { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_BYLd96z_EeeBVbuVcoH9Nw")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection44? TradeAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_BYLd-az_EeeBVbuVcoH9Nw")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection44? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_BYLd-6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection44? IssueDiscountAllowance { get; init; }

    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_BYLd_az_EeeBVbuVcoH9Nw")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection44? PaymentLevyTax { get; init; }

    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_BYLd_6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection44? LocalTax { get; init; }

    /// <summary>
    /// Local tax country specific.
    /// </summary>
    [IsoId("_BYLeAaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc")]
    public AmountAndDirection44? LocalTaxCountrySpecific { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_BYLeA6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection44? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_BYLeBaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection44? Margin { get; init; }

    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_BYLeB6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection44? Other { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_BYLeCaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection44? RegulatoryAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_BYLeC6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection44? ShippingAmount { get; init; }

    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_BYLeDaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection44? SpecialConcession { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_BYLeD6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection44? StampDuty { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_BYLeEaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection44? StockExchangeTax { get; init; }

    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_BYLeE6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection44? TransferTax { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_BYLeFaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection44? TransactionTax { get; init; }

    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_BYLeF6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection44? ValueAddedTax { get; init; }

    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_BYLeGaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection44? WithholdingTax { get; init; }

    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_BYLeG6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection44? NetGainLoss { get; init; }

    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_BYLeHaz_EeeBVbuVcoH9Nw")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection44? ConsumptionTax { get; init; }

    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_BYLeH6z_EeeBVbuVcoH9Nw")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection44? AccruedCapitalisationAmount { get; init; }

    /// <summary>
    /// Charge or commission paid by the investor to a distributor/intermediary or other service provider for the provision of financial research.
    /// </summary>
    [IsoId("_EQqG8az_EeeBVbuVcoH9Nw")]
    [DisplayName("Research Fee")]
    [IsoXmlTag("RsrchFee")]
    public AmountAndDirection44? ResearchFee { get; init; }
}
