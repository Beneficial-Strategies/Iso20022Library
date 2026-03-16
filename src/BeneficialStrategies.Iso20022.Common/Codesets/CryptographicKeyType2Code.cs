// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes for qualifying the type of cryptographic keys;.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wL_l8Cm0EeKIjpr--01h3Q")]
[Description(@"Codes for qualifying the type of cryptographic keys;.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
public enum CryptographicKeyType2Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES2&quot;.
    /// </summary>
    [EnumMember(Value = "AES2")]
    [IsoId("_yZyTMSm0EeKIjpr--01h3Q")]
    [Description(
        @"AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128 = CryptographicKeyTypeCode.AES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data encryption standard key of 112 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE3&quot;.
    /// </summary>
    [EnumMember(Value = "EDE3")]
    [IsoId("_zIyuQym0EeKIjpr--01h3Q")]
    [Description(@"Data encryption standard key of 112 bits (without the parity bits).")]
    DES112 = CryptographicKeyTypeCode.DES112, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_zYRUsym0EeKIjpr--01h3Q")]
    [Description(
        @"DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A."
    )]
    DUKPT2009 = CryptographicKeyTypeCode.DUKPT2009, // same ordinal as derivation source for type conversions
}
