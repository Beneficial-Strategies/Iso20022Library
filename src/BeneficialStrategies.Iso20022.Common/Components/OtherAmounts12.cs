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
[IsoId("_Pa7oYT9jEeCuVfEpWlZb5g")]
[DisplayName("Other Amounts")]
public record OtherAmounts12
{
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_PbFZZT9jEeCuVfEpWlZb5g")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection9? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_PbFZbz9jEeCuVfEpWlZb5g")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection9? ChargesFees { get; init; }

    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_PbFZeT9jEeCuVfEpWlZb5g")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection9? CountryNationalFederalTax { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_PbFZgz9jEeCuVfEpWlZb5g")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection9? TradeAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_PbFZjT9jEeCuVfEpWlZb5g")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_PbFZlz9jEeCuVfEpWlZb5g")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection9? IssueDiscountAllowance { get; init; }

    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_PbFZoT9jEeCuVfEpWlZb5g")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection9? PaymentLevyTax { get; init; }

    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_PbFZqz9jEeCuVfEpWlZb5g")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection9? LocalTax { get; init; }

    /// <summary>
    /// Local tax country specific.
    /// </summary>
    [IsoId("_QFGm1j9jEeCuVfEpWlZb5g")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc")]
    public AmountAndDirection9? LocalTaxCountrySpecific { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_PbFZtT9jEeCuVfEpWlZb5g")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection9? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_PbFZvz9jEeCuVfEpWlZb5g")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection9? Margin { get; init; }

    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_PbFZyT9jEeCuVfEpWlZb5g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection9? Other { get; init; }

    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_PbFZ0z9jEeCuVfEpWlZb5g")]
    [DisplayName("Postage Amount")]
    [IsoXmlTag("PstgAmt")]
    public AmountAndDirection9? PostageAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_PbFZ3T9jEeCuVfEpWlZb5g")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection9? RegulatoryAmount { get; init; }

    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_PbFZ5z9jEeCuVfEpWlZb5g")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection9? ShippingAmount { get; init; }

    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_PbFZ8T9jEeCuVfEpWlZb5g")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection9? SpecialConcession { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_PbFZ-z9jEeCuVfEpWlZb5g")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection9? StampDuty { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_PbFaBT9jEeCuVfEpWlZb5g")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection9? StockExchangeTax { get; init; }

    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_PbFaDz9jEeCuVfEpWlZb5g")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection9? TransferTax { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_PbFaGT9jEeCuVfEpWlZb5g")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection9? TransactionTax { get; init; }

    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_PbFaIz9jEeCuVfEpWlZb5g")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection9? ValueAddedTax { get; init; }

    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_PbFaLT9jEeCuVfEpWlZb5g")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection9? WithholdingTax { get; init; }

    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_PbFaNz9jEeCuVfEpWlZb5g")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection9? NetGainLoss { get; init; }

    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_PbFaQT9jEeCuVfEpWlZb5g")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection9? ConsumptionTax { get; init; }

    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_PbFaSz9jEeCuVfEpWlZb5g")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; }
}
