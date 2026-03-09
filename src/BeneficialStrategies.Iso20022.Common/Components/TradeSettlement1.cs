// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade settlement details for this invoice which involves the payment of an outstanding debt, account, or charge.
/// </summary>
[IsoId("_TB-BBQEcEeCQm6a_G2yO_w_1181239925")]
[DisplayName("Trade Settlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeSettlement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeSettlement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeSettlement1( SettlementMonetarySummation1 reqMonetarySummation )
    {
        MonetarySummation = reqMonetarySummation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Monetary value that is an exact amount due and payable, such as the amount due to the creditor.
    /// </summary>
    [IsoId("_TB-BBgEcEeCQm6a_G2yO_w_-689724916")]
    [DisplayName("Due Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DuePyblAmt")]
    #endif
    [IsoXmlTag("DuePyblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? DuePayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? DuePayableAmount { get; init; } 
    #else
    public CurrencyAndAmount? DuePayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous reference assigned by the creditor.
    /// </summary>
    [IsoId("_TB-BBwEcEeCQm6a_G2yO_w_1023225472")]
    [DisplayName("Creditor Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrRef")]
    #endif
    [IsoXmlTag("CdtrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorReferenceInformation2? CreditorReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorReferenceInformation2? CreditorReference { get; init; } 
    #else
    public CreditorReferenceInformation2? CreditorReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a payment transaction, as assigned by the originator. The payment transaction reference is used for reconciliation or to link tasks relating to the payment transaction.
    /// </summary>
    [IsoId("_TB-BCAEcEeCQm6a_G2yO_w_-2064443525")]
    [DisplayName("Payment Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRef")]
    #endif
    [IsoXmlTag("PmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentReference { get; init; } 
    #else
    public System.String? PaymentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Code specifying the currency of the invoice.
    /// </summary>
    [IsoId("_TB-BCQEcEeCQm6a_G2yO_w_-478697738")]
    [DisplayName("Invoice Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcCcyCd")]
    #endif
    [IsoXmlTag("InvcCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? InvoiceCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InvoiceCurrencyCode { get; init; } 
    #else
    public string? InvoiceCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Organization issuing the invoice.
    /// </summary>
    [IsoId("_TB-BCgEcEeCQm6a_G2yO_w_-961467990")]
    [DisplayName("Invoicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcr")]
    #endif
    [IsoXmlTag("Invcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Invoicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Invoicer { get; init; } 
    #else
    public TradeParty1? Invoicer { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the invoice was issued.
    /// </summary>
    [IsoId("_TB-BCwEcEeCQm6a_G2yO_w_-1680552563")]
    [DisplayName("Invoicee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcee")]
    #endif
    [IsoXmlTag("Invcee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Invoicee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Invoicee { get; init; } 
    #else
    public TradeParty1? Invoicee { get; set; } 
    #endif
    
    /// <summary>
    /// Party specified to receive payment for the invoice.
    /// </summary>
    [IsoId("_TB-BDAEcEeCQm6a_G2yO_w_1939932871")]
    [DisplayName("Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyee")]
    #endif
    [IsoXmlTag("Pyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Payee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Payee { get; init; } 
    #else
    public TradeParty1? Payee { get; set; } 
    #endif
    
    /// <summary>
    /// Party specified to initiate payment for the invoice.
    /// </summary>
    [IsoId("_TB-BDQEcEeCQm6a_G2yO_w_1023227159")]
    [DisplayName("Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyer")]
    #endif
    [IsoXmlTag("Pyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Payer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Payer { get; init; } 
    #else
    public TradeParty1? Payer { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange applicable to a tax.
    /// </summary>
    [IsoId("_TB-BDgEcEeCQm6a_G2yO_w_-274122909")]
    [DisplayName("Tax Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCcyXchg")]
    #endif
    [IsoXmlTag("TaxCcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyReference2? TaxCurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyReference2? TaxCurrencyExchange { get; init; } 
    #else
    public CurrencyReference2? TaxCurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange applicable to the invoice.
    /// </summary>
    [IsoId("_TB-BDwEcEeCQm6a_G2yO_w_490805177")]
    [DisplayName("Invoice Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcCcyXchg")]
    #endif
    [IsoXmlTag("InvcCcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyReference2? InvoiceCurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyReference2? InvoiceCurrencyExchange { get; init; } 
    #else
    public CurrencyReference2? InvoiceCurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange applicable to the payment.
    /// </summary>
    [IsoId("_TB-BEAEcEeCQm6a_G2yO_w_-204302663")]
    [DisplayName("Payment Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCcyXchg")]
    #endif
    [IsoXmlTag("PmtCcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyReference2? PaymentCurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyReference2? PaymentCurrencyExchange { get; init; } 
    #else
    public CurrencyReference2? PaymentCurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Means of payment (for example, credit transfer, cheque, money order, or credit card) specified to initiate payment of the invoice.
    /// </summary>
    [IsoId("_TB-BEQEcEeCQm6a_G2yO_w_776679773")]
    [DisplayName("Payment Means")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMeans")]
    #endif
    [IsoXmlTag("PmtMeans")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentMeans1? PaymentMeans { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMeans1? PaymentMeans { get; init; } 
    #else
    public PaymentMeans1? PaymentMeans { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_TB-BEgEcEeCQm6a_G2yO_w_-417754292")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTax1? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTax1? Tax { get; init; } 
    #else
    public SettlementTax1? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable billing period.
    /// </summary>
    [IsoId("_TB-BEwEcEeCQm6a_G2yO_w_104018694")]
    [DisplayName("Billing Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgPrd")]
    #endif
    [IsoXmlTag("BllgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? BillingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? BillingPeriod { get; init; } 
    #else
    public Period1? BillingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge specified.
    /// </summary>
    [IsoId("_TCHyAAEcEeCQm6a_G2yO_w_-1971858521")]
    [DisplayName("Allowance Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwncChrg")]
    #endif
    [IsoXmlTag("AllwncChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementAllowanceCharge1? AllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementAllowanceCharge1? AllowanceCharge { get; init; } 
    #else
    public SettlementAllowanceCharge1? AllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Tax subtotal calculated.
    /// </summary>
    [IsoId("_TCHyAQEcEeCQm6a_G2yO_w_1581027470")]
    [DisplayName("Sub Total Calculated Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTtlClctdTax")]
    #endif
    [IsoXmlTag("SubTtlClctdTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSubTotalCalculatedTax1? SubTotalCalculatedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSubTotalCalculatedTax1? SubTotalCalculatedTax { get; init; } 
    #else
    public SettlementSubTotalCalculatedTax1? SubTotalCalculatedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Logistics service charge specified.
    /// </summary>
    [IsoId("_TCHyAgEcEeCQm6a_G2yO_w_885870949")]
    [DisplayName("Logistics Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LogstcsChrg")]
    #endif
    [IsoXmlTag("LogstcsChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #else
    public ChargesDetails2? LogisticsCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Payment terms.
    /// </summary>
    [IsoId("_TCHyAwEcEeCQm6a_G2yO_w_2019362636")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerms3? PaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerms3? PaymentTerms { get; init; } 
    #else
    public PaymentTerms3? PaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary totals specified for the invoice.
    /// </summary>
    [IsoId("_TCHyBAEcEeCQm6a_G2yO_w_217295424")]
    [DisplayName("Monetary Summation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntrySummtn")]
    #endif
    [IsoXmlTag("MntrySummtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementMonetarySummation1 MonetarySummation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementMonetarySummation1 MonetarySummation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMonetarySummation1 MonetarySummation { get; init; } 
    #else
    public SettlementMonetarySummation1 MonetarySummation { get; set; } 
    #endif
    
    /// <summary>
    /// Financial adjustment specified.
    /// </summary>
    [IsoId("_TCHyBQEcEeCQm6a_G2yO_w_1706467980")]
    [DisplayName("Adjustment Amount And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntAmtAndRsn")]
    #endif
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentAdjustment2? AdjustmentAmountAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentAdjustment2? AdjustmentAmountAndReason { get; init; } 
    #else
    public DocumentAdjustment2? AdjustmentAmountAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Invoice document referenced.
    /// </summary>
    [IsoId("_TCHyBgEcEeCQm6a_G2yO_w_-2028248160")]
    [DisplayName("Invoice Referenced Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcRefdDoc")]
    #endif
    [IsoXmlTag("InvcRefdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? InvoiceReferencedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? InvoiceReferencedDocument { get; init; } 
    #else
    public DocumentIdentification22? InvoiceReferencedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Pro-forma invoice document referenced.
    /// </summary>
    [IsoId("_TCHyBwEcEeCQm6a_G2yO_w_-1896368987")]
    [DisplayName("Proforma Invoice Referenced Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ProfrmInvcRefdDoc")]
    #endif
    [IsoXmlTag("ProfrmInvcRefdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? ProformaInvoiceReferencedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? ProformaInvoiceReferencedDocument { get; init; } 
    #else
    public DocumentIdentification22? ProformaInvoiceReferencedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Letter of credit document referenced.
    /// </summary>
    [IsoId("_TCHyCAEcEeCQm6a_G2yO_w_2146357070")]
    [DisplayName("Letter Of Credit Referenced Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfCdtRefdDoc")]
    #endif
    [IsoXmlTag("LttrOfCdtRefdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification7? LetterOfCreditReferencedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7? LetterOfCreditReferencedDocument { get; init; } 
    #else
    public DocumentIdentification7? LetterOfCreditReferencedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Financial card specified. The card is used to represent a financial account for the purpose of payment settlement.
    /// </summary>
    [IsoId("_TCHyCQEcEeCQm6a_G2yO_w_316575445")]
    [DisplayName("Financial Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinCard")]
    #endif
    [IsoXmlTag("FinCard")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialCard1? FinancialCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialCard1? FinancialCard { get; init; } 
    #else
    public FinancialCard1? FinancialCard { get; set; } 
    #endif
    
    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_TCHyCgEcEeCQm6a_G2yO_w_180570420")]
    [DisplayName("Purchase Accounting Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsAcctgAcct")]
    #endif
    [IsoXmlTag("PurchsAcctgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #else
    public AccountingAccount1? PurchaseAccountingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Factoring list document referenced.
    /// </summary>
    [IsoId("_TCHyCwEcEeCQm6a_G2yO_w_-1864555444")]
    [DisplayName("Issuer Factoring List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrFactrgListId")]
    #endif
    [IsoXmlTag("IssrFactrgListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerFactoringListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerFactoringListIdentification { get; init; } 
    #else
    public System.String? IssuerFactoringListIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Factoring agreement document referenced.
    /// </summary>
    [IsoId("_TCHyDAEcEeCQm6a_G2yO_w_-626725410")]
    [DisplayName("Issuer Factoring Agreement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrFactrgAgrmtId")]
    #endif
    [IsoXmlTag("IssrFactrgAgrmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerFactoringAgreementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerFactoringAgreementIdentification { get; init; } 
    #else
    public System.String? IssuerFactoringAgreementIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
