// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8jxMYdtkEee9e6xduATmQg")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm19Code>))]
#endif
public enum Algorithm19Code
{
    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS2&quot;.
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_8tjagdtkEee9e6xduATmQg")]
    [Description(
        @"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption)."
    )]
    SHA256WithRSA = AlgorithmCode.SHA256WithRSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS1&quot;.
    /// </summary>
    [EnumMember(Value = "ERS1")]
    [IsoId("_8tjag9tkEee9e6xduATmQg")]
    [Description(
        @"The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption)."
    )]
    SHA1WithRSA = AlgorithmCode.SHA1WithRSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).
    /// Encoded/decoded by serializers as &quot;RPSS&quot;.
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_8tjahdtkEee9e6xduATmQg")]
    [Description(
        @"Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS)."
    )]
    RSASSA_PSS = AlgorithmCode.RSASSA_PSS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fifth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC5&quot;.
    /// </summary>
    [EnumMember(Value = "ECC5")]
    [IsoId("_AqfxMdtlEee9e6xduATmQg")]
    [Description(@"Fifth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFifthAlgortihm =
        AlgorithmCode.EllipticCryptographicCurveFifthAlgortihm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC1&quot;.
    /// </summary>
    [EnumMember(Value = "ECC1")]
    [IsoId("_AvuPcdtlEee9e6xduATmQg")]
    [Description(@"First Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFirstAlgorithm =
        AlgorithmCode.EllipticCryptographicCurveFirstAlgorithm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fourth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC4&quot;.
    /// </summary>
    [EnumMember(Value = "ECC4")]
    [IsoId("_A0_J8dtlEee9e6xduATmQg")]
    [Description(@"Fourth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFourthAlgorithm =
        AlgorithmCode.EllipticCryptographicCurveFourthAlgorithm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Second Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC2&quot;.
    /// </summary>
    [EnumMember(Value = "ECC2")]
    [IsoId("_A5yxcdtlEee9e6xduATmQg")]
    [Description(@"Second Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveSecondAlgorithm =
        AlgorithmCode.EllipticCryptographicCurveSecondAlgorithm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Third Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC3&quot;.
    /// </summary>
    [EnumMember(Value = "ECC3")]
    [IsoId("_A_gX4dtlEee9e6xduATmQg")]
    [Description(@"Third Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveThirdAlgorithm =
        AlgorithmCode.EllipticCryptographicCurveThirdAlgorithm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256).
    /// Encoded/decoded by serializers as &quot;ERS3&quot;.
    /// </summary>
    [EnumMember(Value = "ERS3")]
    [IsoId("_C3GLoNtlEee9e6xduATmQg")]
    [Description(
        @"Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256)."
    )]
    SHA3_256WithRSA = AlgorithmCode.SHA3_256WithRSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-256 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP2&quot;.
    /// </summary>
    [EnumMember(Value = "ECP2")]
    [IsoId("_ZZURwd6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-256 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_256 = AlgorithmCode.SignatureWithEllipticCurveP_256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-384 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP3&quot;.
    /// </summary>
    [EnumMember(Value = "ECP3")]
    [IsoId("_ZeXJ0d6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-384 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_384 = AlgorithmCode.SignatureWithEllipticCurveP_384, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-512 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP5&quot;.
    /// </summary>
    [EnumMember(Value = "ECP5")]
    [IsoId("_ZkqmId6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-512 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_512 = AlgorithmCode.SignatureWithEllipticCurveP_512, // same ordinal as derivation source for type conversions
}
