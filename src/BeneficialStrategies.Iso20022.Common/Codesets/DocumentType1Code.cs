// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axXO1Np-Ed-ak6NoX_4Aeg_1703334295")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType1Code
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as &quot;MSIN&quot;.
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_axXO1dp-Ed-ak6NoX_4Aeg_1703334296")]
    [Description(
        @"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter."
    )]
    MeteredServiceInvoice = DocumentTypeCode.MeteredServiceInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as &quot;CNFA&quot;.
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_axXO1tp-Ed-ak6NoX_4Aeg_1703334297")]
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
    [IsoId("_axXO19p-Ed-ak6NoX_4Aeg_1703334298")]
    [Description(
        @"Document is a debit note for the final amount settled for a commercial transaction."
    )]
    DebitNoteRelatedToFinancialAdjustment = DocumentTypeCode.DebitNoteRelatedToFinancialAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_axXO2Np-Ed-ak6NoX_4Aeg_1703334299")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = DocumentTypeCode.CommercialInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_axg_0Np-Ed-ak6NoX_4Aeg_1703334307")]
    [Description(@"Document is a credit note.")]
    CreditNote = DocumentTypeCode.CreditNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as &quot;DEBN&quot;.
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_axg_0dp-Ed-ak6NoX_4Aeg_1703334308")]
    [Description(@"Document is a debit note.")]
    DebitNote = DocumentTypeCode.DebitNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as &quot;HIRI&quot;.
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_axg_0tp-Ed-ak6NoX_4Aeg_1703334309")]
    [Description(
        @"Document is an invoice for the hiring of human resources or renting goods or equipment."
    )]
    HireInvoice = DocumentTypeCode.HireInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as &quot;SBIN&quot;.
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_axg_09p-Ed-ak6NoX_4Aeg_1703334310")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice = DocumentTypeCode.SelfBilledInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as &quot;RADM&quot;.
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_axg_1Np-Ed-ak6NoX_4Aeg_1703334311")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage = DocumentTypeCode.RemittanceAdviceMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_axg_1dp-Ed-ak6NoX_4Aeg_1703334312")]
    [Description(
        @"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario."
    )]
    RelatedPaymentInstruction = DocumentTypeCode.RelatedPaymentInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as &quot;CMCN&quot;.
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_axg_1tp-Ed-ak6NoX_4Aeg_1703334569")]
    [Description(
        @"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services."
    )]
    CommercialContract = DocumentTypeCode.CommercialContract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as &quot;FXDR&quot;.
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_axg_19p-Ed-ak6NoX_4Aeg_1703334570")]
    [Description(
        @"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers."
    )]
    ForeignExchangeDealReference = DocumentTypeCode.ForeignExchangeDealReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a statement of the transactions posted to the debtor&apos;s account at the supplier.
    /// Encoded/decoded by serializers as &quot;SOAC&quot;.
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_axg_2Np-Ed-ak6NoX_4Aeg_1703334571")]
    [Description(
        @"Document is a statement of the transactions posted to the debtor's account at the supplier."
    )]
    StatementOfAccount = DocumentTypeCode.StatementOfAccount, // same ordinal as derivation source for type conversions
}
