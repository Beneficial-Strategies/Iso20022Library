// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes for qualifying the type of cryptographic keys.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBMBwaACEfC4Q_xhaK1hdQ")]
[Description(@"Codes for qualifying the type of cryptographic keys.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CryptographicKeyType5Code>))]
public enum CryptographicKeyType5Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES2&quot;.
    /// </summary>
    [EnumMember(Value = "AES2")]
    [IsoId("_jCaJxaACEfC4Q_xhaK1hdQ")]
    [Description(@"AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128 = CryptographicKeyTypeCode.AES128,

    /// <summary>
    /// Data encryption standard key of 112 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE3&quot;.
    /// </summary>
    [EnumMember(Value = "EDE3")]
    [IsoId("_jCaJx6ACEfC4Q_xhaK1hdQ")]
    [Description(@"Data encryption standard key of 112 bits (without the parity bits).")]
    DES112 = CryptographicKeyTypeCode.DES112,

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_jCaJyaACEfC4Q_xhaK1hdQ")]
    [Description(@"DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.")]
    DUKPT2009 = CryptographicKeyTypeCode.DUKPT2009,

    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES9&quot;.
    /// </summary>
    [EnumMember(Value = "AES9")]
    [IsoId("_jCaJy6ACEfC4Q_xhaK1hdQ")]
    [Description(@"AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES192 = CryptographicKeyTypeCode.AES192,

    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES5&quot;.
    /// </summary>
    [EnumMember(Value = "AES5")]
    [IsoId("_jCaJzaACEfC4Q_xhaK1hdQ")]
    [Description(@"AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES256 = CryptographicKeyTypeCode.AES256,

    /// <summary>
    /// Data encryption standard key of 168 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE4&quot;.
    /// </summary>
    [EnumMember(Value = "EDE4")]
    [IsoId("_jCaJz6ACEfC4Q_xhaK1hdQ")]
    [Description(@"Data encryption standard key of 168 bits (without the parity bits).")]
    DES168 = CryptographicKeyTypeCode.DES168,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standard.
    /// Encoded/decoded by serializers as &quot;UKA2&quot;.
    /// </summary>
    [EnumMember(Value = "UKA2")]
    [IsoId("_9sNoAaAEEfC4Q_xhaK1hdQ")]
    [Description(@"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standard.")]
    UKPTAES192 = CryptographicKeyTypeCode.UKPTAES192,

    /// <summary>
    /// UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a  256 bits length key. |FIPS 197 - 6 November 2001).
    /// Encoded/decoded by serializers as &quot;UKA6&quot;.
    /// </summary>
    [EnumMember(Value = "UKA6")]
    [IsoId("__5vPgaAEEfC4Q_xhaK1hdQ")]
    [Description(@"UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a  256 bits length key. |FIPS 197 - 6 November 2001).")]
    UKPTAES256 = CryptographicKeyTypeCode.UKPTAES256,

    /// <summary>
    /// Rivest, Shamir and Adleman.
    /// Encoded/decoded by serializers as &quot;RSAC&quot;.
    /// </summary>
    [EnumMember(Value = "RSAC")]
    [IsoId("_A4U-saAFEfC4Q_xhaK1hdQ")]
    [Description(@"Rivest, Shamir and Adleman.")]
    RSA = CryptographicKeyTypeCode.RSA,

    /// <summary>
    /// Elliptic-curve cryptography.
    /// Encoded/decoded by serializers as &quot;ECCC&quot;.
    /// </summary>
    [EnumMember(Value = "ECCC")]
    [IsoId("_BKGrMaAFEfC4Q_xhaK1hdQ")]
    [Description(@"Elliptic-curve cryptography.")]
    ECC = CryptographicKeyTypeCode.ECC,

    /// <summary>
    /// DUKPT AES (Derived Unique Key Per Transaction) algorithm.
    /// Encoded/decoded by serializers as &quot;DKAE&quot;.
    /// </summary>
    [EnumMember(Value = "DKAE")]
    [IsoId("_CGR_kaAFEfC4Q_xhaK1hdQ")]
    [Description(@"DUKPT AES (Derived Unique Key Per Transaction) algorithm.")]
    DUKPTAES = CryptographicKeyTypeCode.DUKPTAES,

    /// <summary>
    /// UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a 128 bits length key. |FIPS 197 - 6 November 2001).
    /// Encoded/decoded by serializers as &quot;UKA8&quot;.
    /// </summary>
    [EnumMember(Value = "UKA8")]
    [IsoId("_GvfYMaB6EfC4Q_xhaK1hdQ")]
    [Description(@"UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a 128 bits length key. |FIPS 197 - 6 November 2001).")]
    UKPTAES128 = CryptographicKeyTypeCode.UKPTAES128,
}
