// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of creditor reference as published in an external creditor reference type code set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCreditorReferenceType1Code")]
[Description(
    @"Specifies the type of creditor reference as published in an external creditor reference type code set."
)]
[DerivedFrom(typeof(ExternalCreditorReferenceTypeCode))]
public enum ExternalCreditorReferenceType1Code
{
    /// <summary>
    /// Document is a dispatch advice.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ExternalCreditorReferenceType1Code_DispatchAdvice")]
    [Description(@"Document is a dispatch advice.")]
    DispatchAdvice = ExternalCreditorReferenceTypeCode.DispatchAdvice,

    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as &quot;FXDR&quot;.
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_ExternalCreditorReferenceType1Code_ForeignExchangeDealReference")]
    [Description(
        @"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers."
    )]
    ForeignExchangeDealReference = ExternalCreditorReferenceTypeCode.ForeignExchangeDealReference,

    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as &quot;PUOR&quot;.
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_ExternalCreditorReferenceType1Code_PurchaseOrder")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder = ExternalCreditorReferenceTypeCode.PurchaseOrder,

    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as &quot;RADM&quot;.
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_ExternalCreditorReferenceType1Code_RemittanceAdviceMessage")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage = ExternalCreditorReferenceTypeCode.RemittanceAdviceMessage,

    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as &quot;RPIN&quot;.
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_ExternalCreditorReferenceType1Code_RelatedPaymentInstruction")]
    [Description(
        @"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario."
    )]
    RelatedPaymentInstruction = ExternalCreditorReferenceTypeCode.RelatedPaymentInstruction,

    /// <summary>
    /// Document is a structured communication reference provided by the creditor to identify the referred transaction.
    /// Encoded/decoded by serializers as &quot;SCOR&quot;.
    /// </summary>
    [EnumMember(Value = "SCOR")]
    [IsoId("_ExternalCreditorReferenceType1Code_StructuredCommunicationReference")]
    [Description(
        @"Document is a structured communication reference provided by the creditor to identify the referred transaction."
    )]
    StructuredCommunicationReference =
        ExternalCreditorReferenceTypeCode.StructuredCommunicationReference,
}
