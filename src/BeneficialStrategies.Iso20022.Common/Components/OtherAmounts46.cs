// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other Amounts46.
/// </summary>
[IsoId("_mLikAYV1Ee-Pv9KR9bv9IA")]
[DisplayName("Other Amounts46")]
public record OtherAmounts46
{
    /// <summary>
    /// Accrued Capitalisation Amount.
    /// </summary>
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection44? AccruedCapitalisationAmount { get; init; }

    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection44? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Book Value.
    /// </summary>
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection44? BookValue { get; init; }

    /// <summary>
    /// Charges Fees.
    /// </summary>
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection44? ChargesFees { get; init; }

    /// <summary>
    /// Collateral Monitor Amount.
    /// </summary>
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection44? CollateralMonitorAmount { get; init; }

    /// <summary>
    /// Consumption Tax.
    /// </summary>
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection44? ConsumptionTax { get; init; }

    /// <summary>
    /// Country National Federal Tax.
    /// </summary>
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection44? CountryNationalFederalTax { get; init; }

    /// <summary>
    /// Executing Broker Amount.
    /// </summary>
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection44? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Issue Discount Allowance.
    /// </summary>
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection44? IssueDiscountAllowance { get; init; }

    /// <summary>
    /// Local Broker Commission.
    /// </summary>
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection44? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Local Tax.
    /// </summary>
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection44? LocalTax { get; init; }

    /// <summary>
    /// Local Tax Country Specific.
    /// </summary>
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc")]
    public AmountAndDirection44? LocalTaxCountrySpecific { get; init; }

    /// <summary>
    /// Margin.
    /// </summary>
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection44? Margin { get; init; }

    /// <summary>
    /// Net Gain Loss.
    /// </summary>
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection44? NetGainLoss { get; init; }

    /// <summary>
    /// Network Fee.
    /// </summary>
    [DisplayName("Network Fee")]
    [IsoXmlTag("NtwkFee")]
    public AmountAndDirection44? NetworkFee { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection44? Other { get; init; }

    /// <summary>
    /// Payment Levy Tax.
    /// </summary>
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection44? PaymentLevyTax { get; init; }

    /// <summary>
    /// Regulatory Amount.
    /// </summary>
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection44? RegulatoryAmount { get; init; }

    /// <summary>
    /// Research Fee.
    /// </summary>
    [DisplayName("Research Fee")]
    [IsoXmlTag("RsrchFee")]
    public AmountAndDirection44? ResearchFee { get; init; }

    /// <summary>
    /// Shipping Amount.
    /// </summary>
    [DisplayName("Shipping Amount")]
    [IsoXmlTag("ShppgAmt")]
    public AmountAndDirection44? ShippingAmount { get; init; }

    /// <summary>
    /// Special Concession.
    /// </summary>
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection44? SpecialConcession { get; init; }

    /// <summary>
    /// Stamp Duty.
    /// </summary>
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection44? StampDuty { get; init; }

    /// <summary>
    /// Stock Exchange Tax.
    /// </summary>
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection44? StockExchangeTax { get; init; }

    /// <summary>
    /// Trade Amount.
    /// </summary>
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection44? TradeAmount { get; init; }

    /// <summary>
    /// Transaction Tax.
    /// </summary>
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection44? TransactionTax { get; init; }

    /// <summary>
    /// Transfer Tax.
    /// </summary>
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection44? TransferTax { get; init; }

    /// <summary>
    /// Value Added Tax.
    /// </summary>
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection44? ValueAddedTax { get; init; }

    /// <summary>
    /// Withholding Tax.
    /// </summary>
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection44? WithholdingTax { get; init; }
}
