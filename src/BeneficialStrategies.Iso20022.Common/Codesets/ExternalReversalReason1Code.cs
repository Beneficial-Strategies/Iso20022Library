// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reversal reason, as published in an external reversal reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amolhNp-Ed-ak6NoX_4Aeg_1644342151")]
[Description(
    @"Specifies the reversal reason, as published in an external reversal reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalReversalReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalReversalReason1Code>))]
#endif
public enum ExternalReversalReason1Code
{
    /// <summary>
    /// Wrong IBAN in  SCT
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t8gqIvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in  SCT")]
    InvalidCreditorAccountNumber = ExternalReversalReasonCode.InvalidCreditorAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t8gqJfRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber = ExternalReversalReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t8gqKPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode = ExternalReversalReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t8gqK_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication = ExternalReversalReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wrong amount in SCT
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t8qbIvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong amount in SCT")]
    WrongAmount = ExternalReversalReasonCode.WrongAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t8qbJfRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate = ExternalReversalReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_t8qbKPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue = ExternalReversalReasonCode.CollectionNotDue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t8qbK_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated =
        ExternalReversalReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t8qbLvRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = ExternalReversalReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wrong BIC in SCT
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t8zlEvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong BIC in SCT")]
    InvalidCreditorBICIdentifier = ExternalReversalReasonCode.InvalidCreditorBICIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8zlFfRYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime = ExternalReversalReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
}
