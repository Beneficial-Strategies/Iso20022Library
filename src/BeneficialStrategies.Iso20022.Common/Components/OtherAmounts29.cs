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
[IsoId("_tiCygzp8EeWVrPy0StzzSg")]
[DisplayName("Other Amounts")]
public record OtherAmounts29
{
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_uA_YMzp8EeWVrPy0StzzSg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection44? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_uA_YOzp8EeWVrPy0StzzSg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection44? ChargesFees { get; init; }

    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_uA_YQzp8EeWVrPy0StzzSg")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection44? CountryNationalFederalTax { get; init; }

    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_uA_YSzp8EeWVrPy0StzzSg")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection44? PaymentLevyTax { get; init; }

    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_uA_YUzp8EeWVrPy0StzzSg")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection44? LocalTax { get; init; }

    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_uA_YWzp8EeWVrPy0StzzSg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection44? Other { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_uA_YYzp8EeWVrPy0StzzSg")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection44? RegulatoryAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_uA_Yazp8EeWVrPy0StzzSg")]
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection44? ShippingAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_uA_Yczp8EeWVrPy0StzzSg")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection44? StampDuty { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_uA_Yezp8EeWVrPy0StzzSg")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection44? StockExchangeTax { get; init; }

    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_uA_Ygzp8EeWVrPy0StzzSg")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection44? TransferTax { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_uA_Yizp8EeWVrPy0StzzSg")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection44? TransactionTax { get; init; }

    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_uA_Ykzp8EeWVrPy0StzzSg")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection44? ValueAddedTax { get; init; }

    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_uA_Ymzp8EeWVrPy0StzzSg")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection44? WithholdingTax { get; init; }

    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_uA_Yozp8EeWVrPy0StzzSg")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection44? ConsumptionTax { get; init; }

    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_uA_Yqzp8EeWVrPy0StzzSg")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection44? AccruedCapitalisationAmount { get; init; }
}
