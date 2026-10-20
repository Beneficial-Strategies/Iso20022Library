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
[IsoId("_mW7hAXR9EfC68Y4jZPNEug")]
[Description(@"Contains the list of key types that may be exchanged.")]
[DerivedFrom(typeof(KeyTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<KeyType2Code>))]
public enum KeyType2Code
{
    /// <summary>
    /// PIN translation key applicable to the acquirer
    /// Encoded/decoded by serializers as &quot;PTKA&quot;.
    /// </summary>
    [EnumMember(Value = "PTKA")]
    [IsoId("_mZgT5XR9EfC68Y4jZPNEug")]
    [Description(@"PIN translation key applicable to the acquirer")]
    PINTranslationKeyAcquirer = KeyTypeCode.PINTranslationKeyAcquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN translation key applicable to the issuer
    /// Encoded/decoded by serializers as &quot;PTKI&quot;.
    /// </summary>
    [EnumMember(Value = "PTKI")]
    [IsoId("_mZgT53R9EfC68Y4jZPNEug")]
    [Description(@"PIN translation key applicable to the issuer")]
    PINTranslationKeyIssuer = KeyTypeCode.PINTranslationKeyIssuer, // same ordinal as derivation source for type conversions
}
