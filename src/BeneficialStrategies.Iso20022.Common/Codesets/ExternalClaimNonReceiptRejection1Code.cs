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
[IsoId("_pAS38IluEeePr-EGJjGYzQ")]
[Description(@"Specifies the reason for the rejection of a claim non receipt, as published in an external claim non receipt rejection code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalClaimNonReceiptRejectionCode))]
public enum ExternalClaimNonReceiptRejection1Code
{
    /// <summary>
    /// Original credit transfer never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_ubNYWPRYEeuLhpyIdtJzwg")]
    [Description(@"Original credit transfer never received.")]
    NoOriginalTransactionReceived = ExternalClaimNonReceiptRejectionCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original credit transfer was received but is not processable.
    /// Encoded/decoded by serializers as &quot;RNPR&quot;.
    /// </summary>
    [EnumMember(Value = "RNPR")]
    [IsoId("_ubNYW_RYEeuLhpyIdtJzwg")]
    [Description(@"Original credit transfer was received but is not processable.")]
    OriginalTransactionReceivedButNotProcessable = ExternalClaimNonReceiptRejectionCode.OriginalTransactionReceivedButNotProcessable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Already rejected original SCT (SEPA Credit Transfer).
    /// Encoded/decoded by serializers as &quot;ARJT&quot;.
    /// </summary>
    [EnumMember(Value = "ARJT")]
    [IsoId("_ubNYXvRYEeuLhpyIdtJzwg")]
    [Description(@"Already rejected original SCT (SEPA Credit Transfer).")]
    AlreadyRejectedTransaction = ExternalClaimNonReceiptRejectionCode.AlreadyRejectedTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Already returned original SCT (SEPA Credit Transfer).
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_ubWiQvRYEeuLhpyIdtJzwg")]
    [Description(@"Already returned original SCT (SEPA Credit Transfer).")]
    AlreadyReturnedTransaction = ExternalClaimNonReceiptRejectionCode.AlreadyReturnedTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_ubWiRfRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory reason.")]
    RegulatoryReason = ExternalClaimNonReceiptRejectionCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
}
