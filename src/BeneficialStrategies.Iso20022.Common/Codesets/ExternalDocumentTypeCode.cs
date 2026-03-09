// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the document type as published in an external document type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8jvwwJGCEeeBGrZP1w0opg")]
[Description(@"Specifies the document type as published in an external document type code list.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalDocumentType1Code))]
public enum ExternalDocumentTypeCode
{
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uHPTc_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_uHPTdvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a credit note for the final amount settled for a commercial transaction.")]
    CreditNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_uHZEcPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services.")]
    Contract,
    
    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_uHZEc_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is a credit note.")]
    CreditNote,
    
    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_uHZEdvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a debit note.")]
    DebitNote,
    
    /// <summary>
    /// Document is an advice of despatch of the goods.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_uHZEefRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an advice of despatch of the goods.")]
    DispatchAdvice,
    
    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;DNFA&quot;.
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_uHZEfPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a debit note for the final amount settled for a commercial transaction.")]
    DebitNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_uHiOYPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice for the hiring of human resources or renting goods or equipment.")]
    HireInvoice,
    
    /// <summary>
    /// Document is a signed invoice.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_uHiOY_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is a signed invoice.")]
    InvoiceSigned,
    
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_uHiOZvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter.")]
    MeteredServiceInvoice,
    
    /// <summary>
    /// In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_uHiOafRYEeuLhpyIdtJzwg")]
    [Description(@"In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer.")]
    ProformaInvoice,
    
    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_uHiObPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder,
    
    /// <summary>
    /// Document is a quotation setting out the conditions under which the goods and/or services are offered.
    /// Encoded/decoded by serializers as &quot;QUOT&quot;.
    /// </summary>
    [EnumMember(Value = "QUOT")]
    [IsoId("_uHr_YPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a quotation setting out the conditions under which the goods and/or services are offered.")]
    Quotation,
    
    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_uHr_Y_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is a statement of the transactions posted to the debtor's account at the supplier.")]
    SelfBilledInvoice,
    
    /// <summary>
    /// Document is a document presented by the seller in support of the procurement of goods and/or services.
    /// Encoded/decoded by serializers as &quot;SPRR&quot;.
    /// </summary>
    [EnumMember(Value = "SPRR")]
    [IsoId("_uH1JUPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a document presented by the seller in support of the procurement of goods and/or services.")]
    SellerPresentment,
    
    /// <summary>
    /// Document is a timesheet recording times for the provision of services and/or delivery of goods.
    /// Encoded/decoded by serializers as &quot;TISH&quot;.
    /// </summary>
    [EnumMember(Value = "TISH")]
    [IsoId("_uH1JU_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is a timesheet recording times for the provision of services and/or delivery of goods.")]
    TimeSheet,
    
    /// <summary>
    /// Document is a usage report indicating the consumption pattern for designated goods and/or services.
    /// Encoded/decoded by serializers as &quot;USAR&quot;.
    /// </summary>
    [EnumMember(Value = "USAR")]
    [IsoId("_uH1JVvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a usage report indicating the consumption pattern for designated goods and/or services.")]
    UsageReport,
    
}
