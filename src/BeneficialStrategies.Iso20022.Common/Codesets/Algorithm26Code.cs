// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Algorithm26Code")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm26Code
{
    /// <summary>
    /// The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1).
    /// Encoded/decoded by serializers as &quot;HS01&quot;.
    /// </summary>
    [EnumMember(Value = "HS01")]
    [IsoId("_Algorithm26Code_SHA1")]
    [Description(
        @"The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1)."
    )]
    SHA1 = AlgorithmCode.SHA1,

    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as &quot;HS25&quot;.
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_Algorithm26Code_SHA256")]
    [Description(
        @"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256)."
    )]
    SHA256 = AlgorithmCode.SHA256,

    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as &quot;HS38&quot;.
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_Algorithm26Code_SHA384")]
    [Description(
        @"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384)."
    )]
    SHA384 = AlgorithmCode.SHA384,

    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as &quot;HS51&quot;.
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_Algorithm26Code_SHA512")]
    [Description(
        @"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512)."
    )]
    SHA512 = AlgorithmCode.SHA512,

    /// <summary>
    /// Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224).
    /// Encoded/decoded by serializers as &quot;SH31&quot;.
    /// </summary>
    [EnumMember(Value = "SH31")]
    [IsoId("_Algorithm26Code_SHA3_224")]
    [Description(
        @"Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224)."
    )]
    SHA3_224 = AlgorithmCode.SHA3_224,

    /// <summary>
    /// Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256).
    /// Encoded/decoded by serializers as &quot;SH32&quot;.
    /// </summary>
    [EnumMember(Value = "SH32")]
    [IsoId("_Algorithm26Code_SHA3_256")]
    [Description(
        @"Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256)."
    )]
    SHA3_256 = AlgorithmCode.SHA3_256,

    /// <summary>
    /// Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384).
    /// Encoded/decoded by serializers as &quot;SH33&quot;.
    /// </summary>
    [EnumMember(Value = "SH33")]
    [IsoId("_Algorithm26Code_SHA3_384")]
    [Description(
        @"Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384)."
    )]
    SHA3_384 = AlgorithmCode.SHA3_384,

    /// <summary>
    /// Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512).
    /// Encoded/decoded by serializers as &quot;SH35&quot;.
    /// </summary>
    [EnumMember(Value = "SH35")]
    [IsoId("_Algorithm26Code_SHA3_512")]
    [Description(
        @"Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512)."
    )]
    SHA3_512 = AlgorithmCode.SHA3_512,

    /// <summary>
    /// Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128).
    /// Encoded/decoded by serializers as &quot;SHK1&quot;.
    /// </summary>
    [EnumMember(Value = "SHK1")]
    [IsoId("_Algorithm26Code_SHAKE128")]
    [Description(
        @"Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128)."
    )]
    SHAKE128 = AlgorithmCode.SHAKE128,

    /// <summary>
    /// Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256).
    /// Encoded/decoded by serializers as &quot;SHK2&quot;.
    /// </summary>
    [EnumMember(Value = "SHK2")]
    [IsoId("_Algorithm26Code_SHAKE256")]
    [Description(
        @"Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256)."
    )]
    SHAKE256 = AlgorithmCode.SHAKE256,

    /// <summary>
    /// ShangMi 3 hash function as defined by ISO/IEC 10118-3:2018.
    /// Encoded/decoded by serializers as &quot;SMS3&quot;.
    /// </summary>
    [EnumMember(Value = "SMS3")]
    [IsoId("_Algorithm26Code_SM3")]
    [Description(@"ShangMi 3 hash function as defined by ISO/IEC 10118-3:2018.")]
    SM3,
}
