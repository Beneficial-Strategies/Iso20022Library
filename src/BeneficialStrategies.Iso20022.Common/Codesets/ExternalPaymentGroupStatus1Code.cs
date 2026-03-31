// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v9bSwWXiEeap-P22vGV91g")]
[Description(
    @"Specifies the status of a group of payment instructions, as published in an external payment group status code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalPaymentGroupStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalPaymentGroupStatus1Code>))]
#endif
public enum ExternalPaymentGroupStatus1Code
{
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_uW4R9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Preceding check of technical validation was successful. Customer profile check was also successful."
    )]
    AcceptedCustomerProfile = ExternalPaymentGroupStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed.
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_uXCC8vRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement on the creditor's account has been completed.")]
    AcceptedSettlementCompletedCreditorAccount =
        ExternalPaymentGroupStatusCode.AcceptedSettlementCompletedCreditorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed.|Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. |Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_uXCC9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Settlement on the debtor's account has been completed.|Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. |Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement|"
    )]
    AcceptedSettlementCompletedDebitorAccount =
        ExternalPaymentGroupStatusCode.AcceptedSettlementCompletedDebitorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_uXCC-PRYEeuLhpyIdtJzwg")]
    [Description(
        @"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution."
    )]
    AcceptedSettlementInProcess = ExternalPaymentGroupStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication and syntactical and semantical validation are successful
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_uXCC-_RYEeuLhpyIdtJzwg")]
    [Description(@"Authentication and syntactical and semantical validation are successful")]
    AcceptedTechnicalValidation = ExternalPaymentGroupStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_uXLz8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction is accepted but a change will be made, such as date or remittance not sent."
    )]
    AcceptedWithChange = ExternalPaymentGroupStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved|&apos;accepted&apos; status.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_uXLz9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"A number of transactions have been accepted, whereas another number of transactions have not yet achieved|'accepted' status."
    )]
    PartiallyAccepted = ExternalPaymentGroupStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending. Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_uXU94vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation is pending. Further checks and status update will be performed."
    )]
    Pending = ExternalPaymentGroupStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation has been received by the receiving agent
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_uXU95fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment initiation has been received by the receiving agent")]
    Received = ExternalPaymentGroupStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uXU96PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation has been rejected."
    )]
    Rejected = ExternalPaymentGroupStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
