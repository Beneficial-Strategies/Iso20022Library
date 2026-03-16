// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade settlement details for this invoice which involves the payment of an outstanding debt, account, or charge.
/// </summary>
[IsoId("_TB-BBQEcEeCQm6a_G2yO_w_1181239925")]
[DisplayName("Trade Settlement")]
public record TradeSettlement1
{
    /// <summary>
    /// Monetary value that is an exact amount due and payable, such as the amount due to the creditor.
    /// </summary>
    [IsoId("_TB-BBgEcEeCQm6a_G2yO_w_-689724916")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public CurrencyAndAmount? DuePayableAmount { get; init; }

    /// <summary>
    /// Unique and unambiguous reference assigned by the creditor.
    /// </summary>
    [IsoId("_TB-BBwEcEeCQm6a_G2yO_w_1023225472")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    public CreditorReferenceInformation2? CreditorReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a payment transaction, as assigned by the originator. The payment transaction reference is used for reconciliation or to link tasks relating to the payment transaction.
    /// </summary>
    [IsoId("_TB-BCAEcEeCQm6a_G2yO_w_-2064443525")]
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentReference { get; init; }

    /// <summary>
    /// Code specifying the currency of the invoice.
    /// </summary>
    [IsoId("_TB-BCQEcEeCQm6a_G2yO_w_-478697738")]
    [DisplayName("Invoice Currency Code")]
    [IsoXmlTag("InvcCcyCd")]
    public CurrencyCode? InvoiceCurrencyCode { get; init; }

    /// <summary>
    /// Organization issuing the invoice.
    /// </summary>
    [IsoId("_TB-BCgEcEeCQm6a_G2yO_w_-961467990")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public TradeParty1? Invoicer { get; init; }

    /// <summary>
    /// Party to whom the invoice was issued.
    /// </summary>
    [IsoId("_TB-BCwEcEeCQm6a_G2yO_w_-1680552563")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public TradeParty1? Invoicee { get; init; }

    /// <summary>
    /// Party specified to receive payment for the invoice.
    /// </summary>
    [IsoId("_TB-BDAEcEeCQm6a_G2yO_w_1939932871")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public TradeParty1? Payee { get; init; }

    /// <summary>
    /// Party specified to initiate payment for the invoice.
    /// </summary>
    [IsoId("_TB-BDQEcEeCQm6a_G2yO_w_1023227159")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public TradeParty1? Payer { get; init; }

    /// <summary>
    /// Currency exchange applicable to a tax.
    /// </summary>
    [IsoId("_TB-BDgEcEeCQm6a_G2yO_w_-274122909")]
    [DisplayName("Tax Currency Exchange")]
    [IsoXmlTag("TaxCcyXchg")]
    public CurrencyReference2? TaxCurrencyExchange { get; init; }

    /// <summary>
    /// Currency exchange applicable to the invoice.
    /// </summary>
    [IsoId("_TB-BDwEcEeCQm6a_G2yO_w_490805177")]
    [DisplayName("Invoice Currency Exchange")]
    [IsoXmlTag("InvcCcyXchg")]
    public CurrencyReference2? InvoiceCurrencyExchange { get; init; }

    /// <summary>
    /// Currency exchange applicable to the payment.
    /// </summary>
    [IsoId("_TB-BEAEcEeCQm6a_G2yO_w_-204302663")]
    [DisplayName("Payment Currency Exchange")]
    [IsoXmlTag("PmtCcyXchg")]
    public CurrencyReference2? PaymentCurrencyExchange { get; init; }

    /// <summary>
    /// Means of payment (for example, credit transfer, cheque, money order, or credit card) specified to initiate payment of the invoice.
    /// </summary>
    [IsoId("_TB-BEQEcEeCQm6a_G2yO_w_776679773")]
    [DisplayName("Payment Means")]
    [IsoXmlTag("PmtMeans")]
    public PaymentMeans1? PaymentMeans { get; init; }

    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_TB-BEgEcEeCQm6a_G2yO_w_-417754292")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public SettlementTax1? Tax { get; init; }

    /// <summary>
    /// Specifies the applicable billing period.
    /// </summary>
    [IsoId("_TB-BEwEcEeCQm6a_G2yO_w_104018694")]
    [DisplayName("Billing Period")]
    [IsoXmlTag("BllgPrd")]
    public Period1? BillingPeriod { get; init; }

    /// <summary>
    /// Allowance or charge specified.
    /// </summary>
    [IsoId("_TCHyAAEcEeCQm6a_G2yO_w_-1971858521")]
    [DisplayName("Allowance Charge")]
    [IsoXmlTag("AllwncChrg")]
    public SettlementAllowanceCharge1? AllowanceCharge { get; init; }

    /// <summary>
    /// Tax subtotal calculated.
    /// </summary>
    [IsoId("_TCHyAQEcEeCQm6a_G2yO_w_1581027470")]
    [DisplayName("Sub Total Calculated Tax")]
    [IsoXmlTag("SubTtlClctdTax")]
    public SettlementSubTotalCalculatedTax1? SubTotalCalculatedTax { get; init; }

    /// <summary>
    /// Logistics service charge specified.
    /// </summary>
    [IsoId("_TCHyAgEcEeCQm6a_G2yO_w_885870949")]
    [DisplayName("Logistics Charge")]
    [IsoXmlTag("LogstcsChrg")]
    public ChargesDetails2? LogisticsCharge { get; init; }

    /// <summary>
    /// Payment terms.
    /// </summary>
    [IsoId("_TCHyAwEcEeCQm6a_G2yO_w_2019362636")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public PaymentTerms3? PaymentTerms { get; init; }

    /// <summary>
    /// Monetary totals specified for the invoice.
    /// </summary>
    [IsoId("_TCHyBAEcEeCQm6a_G2yO_w_217295424")]
    [DisplayName("Monetary Summation")]
    [IsoXmlTag("MntrySummtn")]
    public required SettlementMonetarySummation1 MonetarySummation { get; init; }

    /// <summary>
    /// Financial adjustment specified.
    /// </summary>
    [IsoId("_TCHyBQEcEeCQm6a_G2yO_w_1706467980")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public DocumentAdjustment2? AdjustmentAmountAndReason { get; init; }

    /// <summary>
    /// Invoice document referenced.
    /// </summary>
    [IsoId("_TCHyBgEcEeCQm6a_G2yO_w_-2028248160")]
    [DisplayName("Invoice Referenced Document")]
    [IsoXmlTag("InvcRefdDoc")]
    public DocumentIdentification22? InvoiceReferencedDocument { get; init; }

    /// <summary>
    /// Pro-forma invoice document referenced.
    /// </summary>
    [IsoId("_TCHyBwEcEeCQm6a_G2yO_w_-1896368987")]
    [DisplayName("Proforma Invoice Referenced Document")]
    [IsoXmlTag("ProfrmInvcRefdDoc")]
    public DocumentIdentification22? ProformaInvoiceReferencedDocument { get; init; }

    /// <summary>
    /// Letter of credit document referenced.
    /// </summary>
    [IsoId("_TCHyCAEcEeCQm6a_G2yO_w_2146357070")]
    [DisplayName("Letter Of Credit Referenced Document")]
    [IsoXmlTag("LttrOfCdtRefdDoc")]
    public DocumentIdentification7? LetterOfCreditReferencedDocument { get; init; }

    /// <summary>
    /// Financial card specified. The card is used to represent a financial account for the purpose of payment settlement.
    /// </summary>
    [IsoId("_TCHyCQEcEeCQm6a_G2yO_w_316575445")]
    [DisplayName("Financial Card")]
    [IsoXmlTag("FinCard")]
    public FinancialCard1? FinancialCard { get; init; }

    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_TCHyCgEcEeCQm6a_G2yO_w_180570420")]
    [DisplayName("Purchase Accounting Account")]
    [IsoXmlTag("PurchsAcctgAcct")]
    public AccountingAccount1? PurchaseAccountingAccount { get; init; }

    /// <summary>
    /// Factoring list document referenced.
    /// </summary>
    [IsoId("_TCHyCwEcEeCQm6a_G2yO_w_-1864555444")]
    [DisplayName("Issuer Factoring List Identification")]
    [IsoXmlTag("IssrFactrgListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerFactoringListIdentification { get; init; }

    /// <summary>
    /// Factoring agreement document referenced.
    /// </summary>
    [IsoId("_TCHyDAEcEeCQm6a_G2yO_w_-626725410")]
    [DisplayName("Issuer Factoring Agreement Identification")]
    [IsoXmlTag("IssrFactrgAgrmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerFactoringAgreementIdentification { get; init; }
}
