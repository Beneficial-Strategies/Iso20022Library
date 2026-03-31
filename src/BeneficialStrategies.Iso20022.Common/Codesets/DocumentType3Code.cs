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
[IsoId("_agEqidp-Ed-ak6NoX_4Aeg_665910872")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DocumentType3Code>))]
#endif
public enum DocumentType3Code
{
    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as &quot;RADM&quot;.
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_agObgNp-Ed-ak6NoX_4Aeg_665911923")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage = DocumentTypeCode.RemittanceAdviceMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_agObgdp-Ed-ak6NoX_4Aeg_665911940")]
    [Description(
        @"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario."
    )]
    RelatedPaymentInstruction = DocumentTypeCode.RelatedPaymentInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as &quot;FXDR&quot;.
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_agObgtp-Ed-ak6NoX_4Aeg_665912235")]
    [Description(
        @"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers."
    )]
    ForeignExchangeDealReference = DocumentTypeCode.ForeignExchangeDealReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_agObg9p-Ed-ak6NoX_4Aeg_665912698")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice = DocumentTypeCode.DispatchAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_agObhNp-Ed-ak6NoX_4Aeg_906952902")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder = DocumentTypeCode.PurchaseOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a structured communication reference provided by the creditor to identify the referred transaction.
    /// Encoded/decoded by serializers as &quot;SCOR&quot;.
    /// </summary>
    [EnumMember(Value = "SCOR")]
    [IsoId("_agObhdp-Ed-ak6NoX_4Aeg_922649765")]
    [Description(
        @"Document is a structured communication reference provided by the creditor to identify the referred transaction."
    )]
    StructuredCommunicationReference = DocumentTypeCode.StructuredCommunicationReference, // same ordinal as derivation source for type conversions
}
