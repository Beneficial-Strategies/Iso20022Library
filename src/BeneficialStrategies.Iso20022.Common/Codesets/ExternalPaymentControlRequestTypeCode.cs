// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hQU4EZIgEeect698_YsnIA")]
[Description(
    @"Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPaymentControlRequestType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalPaymentControlRequestTypeCode>))]
#endif
public enum ExternalPaymentControlRequestTypeCode
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as &quot;RT01&quot;.
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_udl99vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending,

    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as &quot;RT02&quot;.
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_udl9-fRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal,

    /// <summary>
    /// Type is a request to cancel a transaction.
    /// Encoded/decoded by serializers as &quot;RT03&quot;.
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_udl9_PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to cancel a transaction.")]
    Cancellation,

    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as &quot;RT04&quot;.
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_udvH4PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence,

    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as &quot;RT05&quot;.
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_udvH4_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious,
}
