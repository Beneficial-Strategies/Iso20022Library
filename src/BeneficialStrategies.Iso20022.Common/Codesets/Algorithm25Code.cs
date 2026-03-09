// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qQf90S_IEeugIJ3Gvoevmg")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm25Code
{
    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS2&quot;.
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_qd5goS_IEeugIJ3Gvoevmg")]
    [Description(@"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).")]
    SHA256WithRSA = AlgorithmCode.SHA256WithRSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS1&quot;.
    /// </summary>
    [EnumMember(Value = "ERS1")]
    [IsoId("_qd5goy_IEeugIJ3Gvoevmg")]
    [Description(@"The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).")]
    SHA1WithRSA = AlgorithmCode.SHA1WithRSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).
    /// Encoded/decoded by serializers as &quot;RPSS&quot;.
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_qd5gpS_IEeugIJ3Gvoevmg")]
    [Description(@"Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).")]
    RSASSA_PSS = AlgorithmCode.RSASSA_PSS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256).
    /// Encoded/decoded by serializers as &quot;ERS3&quot;.
    /// </summary>
    [EnumMember(Value = "ERS3")]
    [IsoId("_qd5gsS_IEeugIJ3Gvoevmg")]
    [Description(@"Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256).")]
    SHA3_256WithRSA = AlgorithmCode.SHA3_256WithRSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED32&quot;.
    /// </summary>
    [EnumMember(Value = "ED32")]
    [IsoId("_uTpDIS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcdsaSha3_256 = AlgorithmCode.EcdsaSha3_256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED33&quot;.
    /// </summary>
    [EnumMember(Value = "ED33")]
    [IsoId("_uaCmES_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcdsaSha3_384 = AlgorithmCode.EcdsaSha3_384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED35&quot;.
    /// </summary>
    [EnumMember(Value = "ED35")]
    [IsoId("_ud39MS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcdsaSha3_512 = AlgorithmCode.EcdsaSha3_512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED23&quot;.
    /// </summary>
    [EnumMember(Value = "ED23")]
    [IsoId("_ujwiwS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcdsaSha384 = AlgorithmCode.EcdsaSha384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED25&quot;.
    /// </summary>
    [EnumMember(Value = "ED25")]
    [IsoId("_uppIUS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcdsaSha512 = AlgorithmCode.EcdsaSha512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES22&quot;.
    /// </summary>
    [EnumMember(Value = "ES22")]
    [IsoId("_uyHH0S_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcsdsaSha256 = AlgorithmCode.EcsdsaSha256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES32&quot;.
    /// </summary>
    [EnumMember(Value = "ES32")]
    [IsoId("_u4AUcS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcsdaSha3_256 = AlgorithmCode.EcsdaSha3_256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES33&quot;.
    /// </summary>
    [EnumMember(Value = "ES33")]
    [IsoId("_u-syUS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcsdsaSha3_384 = AlgorithmCode.EcsdsaSha3_384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES35&quot;.
    /// </summary>
    [EnumMember(Value = "ES35")]
    [IsoId("_vDo8sS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcsdsaSha3_512 = AlgorithmCode.EcsdsaSha3_512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES23&quot;.
    /// </summary>
    [EnumMember(Value = "ES23")]
    [IsoId("_vIyicS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcsdsaSha384 = AlgorithmCode.EcsdsaSha384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES25&quot;.
    /// </summary>
    [EnumMember(Value = "ES25")]
    [IsoId("_vOBAsS_IEeugIJ3Gvoevmg")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcsdsaSha512 = AlgorithmCode.EcsdsaSha512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED22&quot;.
    /// </summary>
    [EnumMember(Value = "ED22")]
    [IsoId("_wAfNITCREeuCBILTqWePIQ")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcdsaSha256 = AlgorithmCode.EcdsaSha256, // same ordinal as derivation source for type conversions
    
}
