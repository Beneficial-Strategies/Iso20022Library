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
[IsoId("_TRd1lQEcEeCQm6a_G2yO_w_-2000804231")]
[Description(
    @"Specifies the document type as published in an external document type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalDocumentTypeCode))]
public enum ExternalDocumentType1Code
{
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uHPTdfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = ExternalDocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_uHPTePRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a credit note for the final amount settled for a commercial transaction."
    )]
    CreditNoteRelatedToFinancialAdjustment =
        ExternalDocumentTypeCode.CreditNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_uHZEcvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services."
    )]
    Contract = ExternalDocumentTypeCode.Contract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_uHZEdfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a credit note.")]
    CreditNote = ExternalDocumentTypeCode.CreditNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_uHZEePRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a debit note.")]
    DebitNote = ExternalDocumentTypeCode.DebitNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an advice of despatch of the goods.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_uHZEe_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an advice of despatch of the goods.")]
    DispatchAdvice = ExternalDocumentTypeCode.DispatchAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;DNFA&quot;.
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_uHZEfvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a debit note for the final amount settled for a commercial transaction."
    )]
    DebitNoteRelatedToFinancialAdjustment =
        ExternalDocumentTypeCode.DebitNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_uHiOYvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is an invoice for the hiring of human resources or renting goods or equipment."
    )]
    HireInvoice = ExternalDocumentTypeCode.HireInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a signed invoice.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_uHiOZfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a signed invoice.")]
    InvoiceSigned = ExternalDocumentTypeCode.InvoiceSigned, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_uHiOaPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter."
    )]
    MeteredServiceInvoice = ExternalDocumentTypeCode.MeteredServiceInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_uHiOa_RYEeuLhpyIdtJzwg")]
    [Description(
        @"In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer."
    )]
    ProformaInvoice = ExternalDocumentTypeCode.ProformaInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_uHiObvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder = ExternalDocumentTypeCode.PurchaseOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a quotation setting out the conditions under which the goods and/or services are offered.
    /// Encoded/decoded by serializers as &quot;QUOT&quot;.
    /// </summary>
    [EnumMember(Value = "QUOT")]
    [IsoId("_uHr_YvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a quotation setting out the conditions under which the goods and/or services are offered."
    )]
    Quotation = ExternalDocumentTypeCode.Quotation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_uHr_ZfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a statement of the transactions posted to the debtor's account at the supplier."
    )]
    SelfBilledInvoice = ExternalDocumentTypeCode.SelfBilledInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a document presented by the seller in support of the procurement of goods and/or services.
    /// Encoded/decoded by serializers as &quot;SPRR&quot;.
    /// </summary>
    [EnumMember(Value = "SPRR")]
    [IsoId("_uH1JUvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a document presented by the seller in support of the procurement of goods and/or services."
    )]
    SellerPresentment = ExternalDocumentTypeCode.SellerPresentment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a timesheet recording times for the provision of services and/or delivery of goods.
    /// Encoded/decoded by serializers as &quot;TISH&quot;.
    /// </summary>
    [EnumMember(Value = "TISH")]
    [IsoId("_uH1JVfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a timesheet recording times for the provision of services and/or delivery of goods."
    )]
    TimeSheet = ExternalDocumentTypeCode.TimeSheet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a usage report indicating the consumption pattern for designated goods and/or services.
    /// Encoded/decoded by serializers as &quot;USAR&quot;.
    /// </summary>
    [EnumMember(Value = "USAR")]
    [IsoId("_uH1JWPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Document is a usage report indicating the consumption pattern for designated goods and/or services."
    )]
    UsageReport = ExternalDocumentTypeCode.UsageReport, // same ordinal as derivation source for type conversions
}
