// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of the cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NwgesItJEeSxlKlAGYErFg")]
[Description(@"Category of the cryptographic key.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CryptographicKeyType4Code>))]
#endif
public enum CryptographicKeyType4Code
{
    /// <summary>
    /// Key used to protect application information.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_VAq5oYtJEeSxlKlAGYErFg")]
    [Description(@"Key used to protect application information.")]
    Application = CryptographicKeyTypeCode.Application, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key used to protect data in the messages.
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_VKNQI4tJEeSxlKlAGYErFg")]
    [Description(@"Key used to protect data in the messages.")]
    Data = CryptographicKeyTypeCode.Data, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any cryptographic key that can be downloaded.
    /// Encoded/decoded by serializers as &quot;DYNC&quot;.
    /// </summary>
    [EnumMember(Value = "DYNC")]
    [IsoId("_VcPbU4tJEeSxlKlAGYErFg")]
    [Description(@"Any cryptographic key that can be downloaded.")]
    Dynamic = CryptographicKeyTypeCode.Dynamic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key used to encrypt other keys.
    /// Encoded/decoded by serializers as &quot;KENC&quot;.
    /// </summary>
    [EnumMember(Value = "KENC")]
    [IsoId("_Vntrg4tJEeSxlKlAGYErFg")]
    [Description(@"Key used to encrypt other keys.")]
    KeyEncryption = CryptographicKeyTypeCode.KeyEncryption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key used to generate the MAC of a message.
    /// Encoded/decoded by serializers as &quot;MACK&quot;.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_V28aU4tJEeSxlKlAGYErFg")]
    [Description(@"Key used to generate the MAC of a message.")]
    MAC = CryptographicKeyTypeCode.MAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key used to encrypt a PIN.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_WBHC84tJEeSxlKlAGYErFg")]
    [Description(@"Key used to encrypt a PIN.")]
    PIN = CryptographicKeyTypeCode.PIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Temporary key used to download keys.
    /// Encoded/decoded by serializers as &quot;WRKG&quot;.
    /// </summary>
    [EnumMember(Value = "WRKG")]
    [IsoId("_WJwBk4tJEeSxlKlAGYErFg")]
    [Description(@"Temporary key used to download keys.")]
    Working = CryptographicKeyTypeCode.Working, // same ordinal as derivation source for type conversions
}
