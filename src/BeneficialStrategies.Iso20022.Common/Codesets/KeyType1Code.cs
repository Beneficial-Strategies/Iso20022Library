// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of key types that may be exchanged.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BuhW0DEtEemzCpWiCwK4aQ")]
[Description(@"Contains the list of key types that may be exchanged.")]
[DerivedFrom(typeof(KeyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<KeyType1Code>))]
#endif
public enum KeyType1Code
{
    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EnKX4TEtEemzCpWiCwK4aQ")]
    [Description(@"Other national")]
    OtherNational = KeyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_E7SNwTEtEemzCpWiCwK4aQ")]
    [Description(@"Other private")]
    OtherPrivate = KeyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN translation key applicable to the acquirer
    /// Encoded/decoded by serializers as &quot;PTKA&quot;.
    /// </summary>
    [EnumMember(Value = "PTKA")]
    [IsoId("_FP-EUTEtEemzCpWiCwK4aQ")]
    [Description(@"PIN translation key applicable to the acquirer")]
    PINTranslationKeyAcquirer = KeyTypeCode.PINTranslationKeyAcquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN translation key applicable to the issuer
    /// Encoded/decoded by serializers as &quot;PTKI&quot;.
    /// </summary>
    [EnumMember(Value = "PTKI")]
    [IsoId("_FluR4TEtEemzCpWiCwK4aQ")]
    [Description(@"PIN translation key applicable to the issuer")]
    PINTranslationKeyIssuer = KeyTypeCode.PINTranslationKeyIssuer, // same ordinal as derivation source for type conversions
}
