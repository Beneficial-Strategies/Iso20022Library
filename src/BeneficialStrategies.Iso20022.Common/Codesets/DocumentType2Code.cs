// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_af7gl9p-Ed-ak6NoX_4Aeg_-1135079340")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DocumentType2Code>))]
#endif
public enum DocumentType2Code
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_af7gmNp-Ed-ak6NoX_4Aeg_-1135079244")]
    [Description(
        @"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter."
    )]
    MeteredServiceInvoice = DocumentTypeCode.MeteredServiceInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_af7gmdp-Ed-ak6NoX_4Aeg_-1135079227")]
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
    [IsoId("_agEqgNp-Ed-ak6NoX_4Aeg_-1135079209")]
    [Description(
        @"Document is a debit note for the final amount settled for a commercial transaction."
    )]
    DebitNoteRelatedToFinancialAdjustment = DocumentTypeCode.DebitNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_agEqgdp-Ed-ak6NoX_4Aeg_-1135078967")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_agEqgtp-Ed-ak6NoX_4Aeg_-1135078950")]
    [Description(@"Document is a credit note.")]
    CreditNote = DocumentTypeCode.CreditNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_agEqg9p-Ed-ak6NoX_4Aeg_-1135078932")]
    [Description(@"Document is a debit note.")]
    DebitNote = DocumentTypeCode.DebitNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_agEqhNp-Ed-ak6NoX_4Aeg_-1135078915")]
    [Description(
        @"Document is an invoice for the hiring of human resources or renting goods or equipment."
    )]
    HireInvoice = DocumentTypeCode.HireInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_agEqhdp-Ed-ak6NoX_4Aeg_-1135078897")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice = DocumentTypeCode.SelfBilledInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as &quot;CMCN&quot;.
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_agEqhtp-Ed-ak6NoX_4Aeg_-1135078837")]
    [Description(
        @"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services."
    )]
    CommercialContract = DocumentTypeCode.CommercialContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SOAC&quot;.
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_agEqh9p-Ed-ak6NoX_4Aeg_-1135078795")]
    [Description(
        @"Document is a statement of the transactions posted to the debtor's account at the supplier."
    )]
    StatementOfAccount = DocumentTypeCode.StatementOfAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_agEqiNp-Ed-ak6NoX_4Aeg_-864489577")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice = DocumentTypeCode.DispatchAdvice, // same ordinal as derivation source for type conversions
}
