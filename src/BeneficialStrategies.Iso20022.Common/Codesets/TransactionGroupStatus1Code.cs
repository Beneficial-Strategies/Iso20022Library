// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrZn49p-Ed-ak6NoX_4Aeg_-2100712417")]
[Description(@"Specifies the status of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionGroupStatus1Code>))]
#endif
public enum TransactionGroupStatus1Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_YrZn5Np-Ed-ak6NoX_4Aeg_-2100712382")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation = PaymentStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation has been received by the receiving agent.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_YrZn5dp-Ed-ak6NoX_4Aeg_-2100712357")]
    [Description(@"Payment initiation has been received by the receiving agent.")]
    Received = PaymentStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved &apos;accepted&apos; status.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_YrZn5tp-Ed-ak6NoX_4Aeg_-2100712322")]
    [Description(
        @"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status."
    )]
    PartiallyAccepted = PaymentStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YrZn59p-Ed-ak6NoX_4Aeg_-2100712032")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation has been rejected."
    )]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_YrZn6Np-Ed-ak6NoX_4Aeg_-2100712014")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed."
    )]
    Pending = PaymentStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_YrjY4Np-Ed-ak6NoX_4Aeg_-2100711979")]
    [Description(
        @"Preceding check of technical validation was successful. Customer profile check was also successful."
    )]
    AcceptedCustomerProfile = PaymentStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_YrjY4dp-Ed-ak6NoX_4Aeg_-2100711937")]
    [Description(
        @"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution."
    )]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_YrjY4tp-Ed-ak6NoX_4Aeg_-2100711919")]
    [Description(
        @"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement"
    )]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_YrjY49p-Ed-ak6NoX_4Aeg_-1715877559")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest = PaymentStatusCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_YrjY5Np-Ed-ak6NoX_4Aeg_-1673394573")]
    [Description(
        @"Instruction is accepted but a change will be made, such as date or remittance not sent."
    )]
    AcceptedWithChange = PaymentStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
}
