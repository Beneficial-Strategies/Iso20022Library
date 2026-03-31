// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of creditor reference as published in an external creditor reference type code set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCreditorReferenceTypeCode")]
[Description(
    @"Specifies the type of creditor reference as published in an external creditor reference type code set."
)]
public enum ExternalCreditorReferenceTypeCode
{
    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ExternalCreditorReferenceTypeCode_DispatchAdvice")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice,

    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as &quot;FXDR&quot;.
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_ExternalCreditorReferenceTypeCode_ForeignExchangeDealReference")]
    [Description(
        @"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers."
    )]
    ForeignExchangeDealReference,

    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_ExternalCreditorReferenceTypeCode_PurchaseOrder")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder,

    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as &quot;RADM&quot;.
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_ExternalCreditorReferenceTypeCode_RemittanceAdviceMessage")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage,

    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_ExternalCreditorReferenceTypeCode_RelatedPaymentInstruction")]
    [Description(
        @"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario."
    )]
    RelatedPaymentInstruction,

    /// <summary>
    /// Document is a structured communication reference provided by the creditor to identify the referred transaction.
    /// Encoded/decoded by serializers as &quot;SCOR&quot;.
    /// </summary>
    [EnumMember(Value = "SCOR")]
    [IsoId("_ExternalCreditorReferenceTypeCode_StructuredCommunicationReference")]
    [Description(
        @"Document is a structured communication reference provided by the creditor to identify the referred transaction."
    )]
    StructuredCommunicationReference,
}
