// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the rejection of a claim non receipt, as published in an external claim non receipt rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eIg8sYjXEeeDW7_wB-eK_g")]
[Description(
    @"Specifies the reason for the rejection of a claim non receipt, as published in an external claim non receipt rejection code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalClaimNonReceiptRejection1Code))]
public enum ExternalClaimNonReceiptRejectionCode
{
    /// <summary>
    /// Original credit transfer never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_ubNYVvRYEeuLhpyIdtJzwg")]
    [Description(@"Original credit transfer never received.")]
    NoOriginalTransactionReceived,

    /// <summary>
    /// Original credit transfer was received but is not processable.
    /// Encoded/decoded by serializers as &quot;RNPR&quot;.
    /// </summary>
    [EnumMember(Value = "RNPR")]
    [IsoId("_ubNYWfRYEeuLhpyIdtJzwg")]
    [Description(@"Original credit transfer was received but is not processable.")]
    OriginalTransactionReceivedButNotProcessable,

    /// <summary>
    /// Already rejected original SCT (SEPA Credit Transfer).
    /// Encoded/decoded by serializers as &quot;ARJT&quot;.
    /// </summary>
    [EnumMember(Value = "ARJT")]
    [IsoId("_ubNYXPRYEeuLhpyIdtJzwg")]
    [Description(@"Already rejected original SCT (SEPA Credit Transfer).")]
    AlreadyRejectedTransaction,

    /// <summary>
    /// Already returned original SCT (SEPA Credit Transfer).
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_ubWiQPRYEeuLhpyIdtJzwg")]
    [Description(@"Already returned original SCT (SEPA Credit Transfer).")]
    AlreadyReturnedTransaction,

    /// <summary>
    /// Regulatory reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_ubWiQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory reason.")]
    RegulatoryReason,
}
