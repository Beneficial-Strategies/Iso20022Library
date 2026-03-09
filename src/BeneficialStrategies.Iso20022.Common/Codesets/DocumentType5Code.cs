// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agObiNp-Ed-ak6NoX_4Aeg_1566612187")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType5Code
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_agYMgNp-Ed-ak6NoX_4Aeg_1566612217")]
    [Description(@"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.")]
    MeteredServiceInvoice = DocumentTypeCode.MeteredServiceInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_agYMgdp-Ed-ak6NoX_4Aeg_1566612248")]
    [Description(@"Document is a credit note for the final amount settled for a commercial transaction.")]
    CreditNoteRelatedToFinancialAdjustment = DocumentTypeCode.CreditNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;DNFA&quot;.
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_agYMgtp-Ed-ak6NoX_4Aeg_1566612249")]
    [Description(@"Document is a debit note for the final amount settled for a commercial transaction.")]
    DebitNoteRelatedToFinancialAdjustment = DocumentTypeCode.DebitNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_agYMg9p-Ed-ak6NoX_4Aeg_1566612526")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_agYMhNp-Ed-ak6NoX_4Aeg_1566612557")]
    [Description(@"Document is a credit note.")]
    CreditNote = DocumentTypeCode.CreditNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_agYMhdp-Ed-ak6NoX_4Aeg_1566612588")]
    [Description(@"Document is a debit note.")]
    DebitNote = DocumentTypeCode.DebitNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_agYMhtp-Ed-ak6NoX_4Aeg_1566612618")]
    [Description(@"Document is an invoice for the hiring of human resources or renting goods or equipment.")]
    HireInvoice = DocumentTypeCode.HireInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_agYMh9p-Ed-ak6NoX_4Aeg_1566612649")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice = DocumentTypeCode.SelfBilledInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as &quot;CMCN&quot;.
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_agYMiNp-Ed-ak6NoX_4Aeg_1566612680")]
    [Description(@"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.")]
    CommercialContract = DocumentTypeCode.CommercialContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SOAC&quot;.
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_agYMidp-Ed-ak6NoX_4Aeg_1566612681")]
    [Description(@"Document is a statement of the transactions posted to the debtor's account at the supplier.")]
    StatementOfAccount = DocumentTypeCode.StatementOfAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_aghWcNp-Ed-ak6NoX_4Aeg_1566612710")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice = DocumentTypeCode.DispatchAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a shipping notice.
    /// Encoded/decoded by serializers as &quot;BOLD&quot;.
    /// </summary>
    [EnumMember(Value = "BOLD")]
    [IsoId("_aghWcdp-Ed-ak6NoX_4Aeg_2010826154")]
    [Description(@"Document is a shipping notice.")]
    BillOfLading = DocumentTypeCode.BillOfLading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an electronic payment document.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_aghWctp-Ed-ak6NoX_4Aeg_2027448669")]
    [Description(@"Document is an electronic payment document.")]
    Voucher = DocumentTypeCode.Voucher, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a payment that applies to a specific source document.
    /// Encoded/decoded by serializers as &quot;AROI&quot;.
    /// </summary>
    [EnumMember(Value = "AROI")]
    [IsoId("_aghWc9p-Ed-ak6NoX_4Aeg_2039452669")]
    [Description(@"Document is a payment that applies to a specific source document.")]
    AccountReceivableOpenItem = DocumentTypeCode.AccountReceivableOpenItem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a transaction identifier as assigned by the Trade Services Utility.
    /// Encoded/decoded by serializers as &quot;TSUT&quot;.
    /// </summary>
    [EnumMember(Value = "TSUT")]
    [IsoId("_aghWdNp-Ed-ak6NoX_4Aeg_1739893330")]
    [Description(@"Document is a transaction identifier as assigned by the Trade Services Utility.")]
    TradeServicesUtilityTransaction = DocumentTypeCode.TradeServicesUtilityTransaction, // same ordinal as derivation source for type conversions
    
}
