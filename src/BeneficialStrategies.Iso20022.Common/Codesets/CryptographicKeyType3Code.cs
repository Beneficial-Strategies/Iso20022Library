// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes for qualifying the type of cryptographic keys.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ArIvIWp0EeSMqvBfBY1c9A")]
[Description(@"Codes for qualifying the type of cryptographic keys.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
public enum CryptographicKeyType3Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES2&quot;.
    /// </summary>
    [EnumMember(Value = "AES2")]
    [IsoId("_A4GNEWp0EeSMqvBfBY1c9A")]
    [Description(
        @"AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128 = CryptographicKeyTypeCode.AES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data encryption standard key of 112 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE3&quot;.
    /// </summary>
    [EnumMember(Value = "EDE3")]
    [IsoId("_A4GNE2p0EeSMqvBfBY1c9A")]
    [Description(@"Data encryption standard key of 112 bits (without the parity bits).")]
    DES112 = CryptographicKeyTypeCode.DES112, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_A4GNFWp0EeSMqvBfBY1c9A")]
    [Description(
        @"DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A."
    )]
    DUKPT2009 = CryptographicKeyTypeCode.DUKPT2009, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES9&quot;.
    /// </summary>
    [EnumMember(Value = "AES9")]
    [IsoId("_Ej_QAWp0EeSMqvBfBY1c9A")]
    [Description(
        @"AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192 = CryptographicKeyTypeCode.AES192, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES5&quot;.
    /// </summary>
    [EnumMember(Value = "AES5")]
    [IsoId("_E4s7wWp0EeSMqvBfBY1c9A")]
    [Description(
        @"AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256 = CryptographicKeyTypeCode.AES256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data encryption standard key of 168 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE4&quot;.
    /// </summary>
    [EnumMember(Value = "EDE4")]
    [IsoId("_FL6ysWp0EeSMqvBfBY1c9A")]
    [Description(@"Data encryption standard key of 168 bits (without the parity bits).")]
    DES168 = CryptographicKeyTypeCode.DES168, // same ordinal as derivation source for type conversions
}
