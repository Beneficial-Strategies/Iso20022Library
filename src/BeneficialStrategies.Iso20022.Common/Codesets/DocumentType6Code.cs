// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xEXUIR78EeSxevWRRWxNAg")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType6Code
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_xVb2AR78EeSxevWRRWxNAg")]
    [Description(
        @"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter."
    )]
    MeteredServiceInvoice = DocumentTypeCode.MeteredServiceInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_xVb2Ax78EeSxevWRRWxNAg")]
    [Description(
        @"Document is a credit note for the final amount settled for a commercial transaction."
    )]
    CreditNoteRelatedToFinancialAdjustment =
        DocumentTypeCode.CreditNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;DNFA&quot;.
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_xVb2BR78EeSxevWRRWxNAg")]
    [Description(
        @"Document is a debit note for the final amount settled for a commercial transaction."
    )]
    DebitNoteRelatedToFinancialAdjustment = DocumentTypeCode.DebitNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_xVb2Bx78EeSxevWRRWxNAg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_xVb2CR78EeSxevWRRWxNAg")]
    [Description(@"Document is a credit note.")]
    CreditNote = DocumentTypeCode.CreditNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_xVb2Cx78EeSxevWRRWxNAg")]
    [Description(@"Document is a debit note.")]
    DebitNote = DocumentTypeCode.DebitNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_xVb2DR78EeSxevWRRWxNAg")]
    [Description(
        @"Document is an invoice for the hiring of human resources or renting goods or equipment."
    )]
    HireInvoice = DocumentTypeCode.HireInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_xVb2Dx78EeSxevWRRWxNAg")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice = DocumentTypeCode.SelfBilledInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as &quot;CMCN&quot;.
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_xVb2ER78EeSxevWRRWxNAg")]
    [Description(
        @"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services."
    )]
    CommercialContract = DocumentTypeCode.CommercialContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SOAC&quot;.
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_xVb2Ex78EeSxevWRRWxNAg")]
    [Description(
        @"Document is a statement of the transactions posted to the debtor's account at the supplier."
    )]
    StatementOfAccount = DocumentTypeCode.StatementOfAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_xVb2FR78EeSxevWRRWxNAg")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice = DocumentTypeCode.DispatchAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a shipping notice.
    /// Encoded/decoded by serializers as &quot;BOLD&quot;.
    /// </summary>
    [EnumMember(Value = "BOLD")]
    [IsoId("_xVb2Fx78EeSxevWRRWxNAg")]
    [Description(@"Document is a shipping notice.")]
    BillOfLading = DocumentTypeCode.BillOfLading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an electronic payment document.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_xVb2GR78EeSxevWRRWxNAg")]
    [Description(@"Document is an electronic payment document.")]
    Voucher = DocumentTypeCode.Voucher, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a payment that applies to a specific source document.
    /// Encoded/decoded by serializers as &quot;AROI&quot;.
    /// </summary>
    [EnumMember(Value = "AROI")]
    [IsoId("_xVb2Gx78EeSxevWRRWxNAg")]
    [Description(@"Document is a payment that applies to a specific source document.")]
    AccountReceivableOpenItem = DocumentTypeCode.AccountReceivableOpenItem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a transaction identifier as assigned by the Trade Services Utility.
    /// Encoded/decoded by serializers as &quot;TSUT&quot;.
    /// </summary>
    [EnumMember(Value = "TSUT")]
    [IsoId("_xVb2HR78EeSxevWRRWxNAg")]
    [Description(
        @"Document is a transaction identifier as assigned by the Trade Services Utility."
    )]
    TradeServicesUtilityTransaction = DocumentTypeCode.TradeServicesUtilityTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_zjV4AR78EeSxevWRRWxNAg")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder = DocumentTypeCode.PurchaseOrder, // same ordinal as derivation source for type conversions
}
