// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aghWddp-Ed-ak6NoX_4Aeg_-1963478091")]
[Description(@"Specifies a type of financial or commercial document.")]
[Derivations(typeof(DocumentType4Code),typeof(DocumentType3Code),typeof(DocumentType6Code),typeof(DocumentType1Code),typeof(DocumentType7Code),typeof(DocumentType5Code),typeof(DocumentType2Code))]
public enum DocumentTypeCode
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_aghWdtp-Ed-ak6NoX_4Aeg_1645796385")]
    [Description(@"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.")]
    MeteredServiceInvoice,
    
    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_aghWd9p-Ed-ak6NoX_4Aeg_1645796403")]
    [Description(@"Document is a credit note for the final amount settled for a commercial transaction.")]
    CreditNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;DNFA&quot;.
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_aghWeNp-Ed-ak6NoX_4Aeg_1645796445")]
    [Description(@"Document is a debit note for the final amount settled for a commercial transaction.")]
    DebitNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_agrHcNp-Ed-ak6NoX_4Aeg_1645796463")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_agrHcdp-Ed-ak6NoX_4Aeg_1645796480")]
    [Description(@"Document is a credit note.")]
    CreditNote,
    
    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_agrHctp-Ed-ak6NoX_4Aeg_1645796715")]
    [Description(@"Document is a debit note.")]
    DebitNote,
    
    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_agrHc9p-Ed-ak6NoX_4Aeg_1645796740")]
    [Description(@"Document is an invoice for the hiring of human resources or renting goods or equipment.")]
    HireInvoice,
    
    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_agrHdNp-Ed-ak6NoX_4Aeg_1645796757")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice,
    
    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as &quot;RADM&quot;.
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_agrHddp-Ed-ak6NoX_4Aeg_1645796800")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage,
    
    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_agrHdtp-Ed-ak6NoX_4Aeg_1645796817")]
    [Description(@"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.")]
    RelatedPaymentInstruction,
    
    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as &quot;CMCN&quot;.
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_agrHd9p-Ed-ak6NoX_4Aeg_1645796835")]
    [Description(@"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.")]
    CommercialContract,
    
    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as &quot;FXDR&quot;.
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_agrHeNp-Ed-ak6NoX_4Aeg_1646716824")]
    [Description(@"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.")]
    ForeignExchangeDealReference,
    
    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SOAC&quot;.
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_agrHedp-Ed-ak6NoX_4Aeg_1646716884")]
    [Description(@"Document is a statement of the transactions posted to the debtor's account at the supplier.")]
    StatementOfAccount,
    
    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_agrHetp-Ed-ak6NoX_4Aeg_-1207112892")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice,
    
    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_ag04cNp-Ed-ak6NoX_4Aeg_550471768")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder,
    
    /// <summary>
    /// Document is a structured communication reference provided by the creditor to identify the referred transaction.
    /// Encoded/decoded by serializers as &quot;SCOR&quot;.
    /// </summary>
    [EnumMember(Value = "SCOR")]
    [IsoId("_ag04cdp-Ed-ak6NoX_4Aeg_550472217")]
    [Description(@"Document is a structured communication reference provided by the creditor to identify the referred transaction.")]
    StructuredCommunicationReference,
    
    /// <summary>
    /// Document is a shipping notice.
    /// Encoded/decoded by serializers as &quot;BOLD&quot;.
    /// </summary>
    [EnumMember(Value = "BOLD")]
    [IsoId("_ag04ctp-Ed-ak6NoX_4Aeg_-464327282")]
    [Description(@"Document is a shipping notice.")]
    BillOfLading,
    
    /// <summary>
    /// Document is an electronic payment document.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_ag04c9p-Ed-ak6NoX_4Aeg_-464326980")]
    [Description(@"Document is an electronic payment document.")]
    Voucher,
    
    /// <summary>
    /// Document is a payment that applies to a specific source document.
    /// Encoded/decoded by serializers as &quot;AROI&quot;.
    /// </summary>
    [EnumMember(Value = "AROI")]
    [IsoId("_ag04dNp-Ed-ak6NoX_4Aeg_-464326919")]
    [Description(@"Document is a payment that applies to a specific source document.")]
    AccountReceivableOpenItem,
    
    /// <summary>
    /// Document is a transaction identifier as assigned by the Trade Services Utility.
    /// Encoded/decoded by serializers as &quot;TSUT&quot;.
    /// </summary>
    [EnumMember(Value = "TSUT")]
    [IsoId("_ag04ddp-Ed-ak6NoX_4Aeg_-464326858")]
    [Description(@"Document is a transaction identifier as assigned by the Trade Services Utility.")]
    TradeServicesUtilityTransaction,
    
    /// <summary>
    /// When the Sale system print the Cashier copy of the Payment receipt.
    /// Encoded/decoded by serializers as &quot;HRCP&quot;.
    /// </summary>
    [EnumMember(Value = "HRCP")]
    [IsoId("_xxyWAGpTEemFuJNacM8hZA")]
    [Description(@"When the Sale system print the Cashier copy of the Payment receipt.")]
    CashierReceipt,
    
    /// <summary>
    /// When the Sale System requires	the POI system to print the Customer receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_3nEHUGpTEemFuJNacM8hZA")]
    [Description(@"When the Sale System requires	the POI system to print the Customer receipt.")]
    CustomerReceipt,
    
    /// <summary>
    /// When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer).
    /// Encoded/decoded by serializers as &quot;JNRL&quot;.
    /// </summary>
    [EnumMember(Value = "JNRL")]
    [IsoId("_Az5qUGpUEemFuJNacM8hZA")]
    [Description(@"When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer).")]
    Journal,
    
    /// <summary>
    /// When the Sale System requires the POI system to print the Sale receipt.
    /// Encoded/decoded by serializers as &quot;SRCP&quot;.
    /// </summary>
    [EnumMember(Value = "SRCP")]
    [IsoId("_K7gzgGpUEemFuJNacM8hZA")]
    [Description(@"When the Sale System requires the POI system to print the Sale receipt.")]
    SaleReceipt,
    
}
