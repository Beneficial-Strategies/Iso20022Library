// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C0GiwPS8EeiAX8EjdnKKRw")]
[Description(
    @"Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalMandateStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalMandateStatusCode>))]
#endif
public enum ExternalMandateStatusCode
{
    /// <summary>
    /// The mandate is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_uYrBs_RYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is active.")]
    Active,

    /// <summary>
    /// The mandate is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_uYrBtvRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is cancelled.")]
    Cancelled,

    /// <summary>
    /// The mandate has passed the end date.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_uYrBufRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate has passed the end date.")]
    Expired,

    /// <summary>
    /// The mandate is put on hold.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_uY0ysPRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is put on hold.")]
    Suspended,
}
