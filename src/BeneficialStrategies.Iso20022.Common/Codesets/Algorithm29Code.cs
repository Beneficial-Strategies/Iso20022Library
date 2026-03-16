// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Algorithm29Code")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm29Code
{
    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD22&quot;.
    /// </summary>
    [EnumMember(Value = "DD22")]
    [IsoId("_Algorithm29Code_EddsaSha256")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EddsaSha256,

    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD23&quot;.
    /// </summary>
    [EnumMember(Value = "DD23")]
    [IsoId("_Algorithm29Code_EddsaSha384")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EddsaSha384,

    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD25&quot;.
    /// </summary>
    [EnumMember(Value = "DD25")]
    [IsoId("_Algorithm29Code_EddsaSha512")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EddsaSha512,

    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD32&quot;.
    /// </summary>
    [EnumMember(Value = "DD32")]
    [IsoId("_Algorithm29Code_EddsaSha3_256")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EddsaSha3_256,

    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD33&quot;.
    /// </summary>
    [EnumMember(Value = "DD33")]
    [IsoId("_Algorithm29Code_EddsaSha3_384")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EddsaSha3_384,

    /// <summary>
    /// Edward Curve Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;DD35&quot;.
    /// </summary>
    [EnumMember(Value = "DD35")]
    [IsoId("_Algorithm29Code_EddsaSha3_512")]
    [Description(@"Edward Curve Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.")]
    EddsaSha3_512,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED22&quot;.
    /// </summary>
    [EnumMember(Value = "ED22")]
    [IsoId("_Algorithm29Code_EcdsaSha256")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcdsaSha256 = AlgorithmCode.EcdsaSha256,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED23&quot;.
    /// </summary>
    [EnumMember(Value = "ED23")]
    [IsoId("_Algorithm29Code_EcdsaSha384")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcdsaSha384 = AlgorithmCode.EcdsaSha384,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED25&quot;.
    /// </summary>
    [EnumMember(Value = "ED25")]
    [IsoId("_Algorithm29Code_EcdsaSha512")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcdsaSha512 = AlgorithmCode.EcdsaSha512,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED32&quot;.
    /// </summary>
    [EnumMember(Value = "ED32")]
    [IsoId("_Algorithm29Code_EcdsaSha3_256")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcdsaSha3_256 = AlgorithmCode.EcdsaSha3_256,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED33&quot;.
    /// </summary>
    [EnumMember(Value = "ED33")]
    [IsoId("_Algorithm29Code_EcdsaSha3_384")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcdsaSha3_384 = AlgorithmCode.EcdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED35&quot;.
    /// </summary>
    [EnumMember(Value = "ED35")]
    [IsoId("_Algorithm29Code_EcdsaSha3_512")]
    [Description(@"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcdsaSha3_512 = AlgorithmCode.EcdsaSha3_512,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF22&quot;.
    /// </summary>
    [EnumMember(Value = "EF22")]
    [IsoId("_Algorithm29Code_EcfsdsaSha256")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcfsdsaSha256,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF23&quot;.
    /// </summary>
    [EnumMember(Value = "EF23")]
    [IsoId("_Algorithm29Code_EcfsdsaSha384")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcfsdsaSha384,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF25&quot;.
    /// </summary>
    [EnumMember(Value = "EF25")]
    [IsoId("_Algorithm29Code_EcfsdsaSha512")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcfsdsaSha512,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF32&quot;.
    /// </summary>
    [EnumMember(Value = "EF32")]
    [IsoId("_Algorithm29Code_EcfsdaSha3_256")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcfsdaSha3_256,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF33&quot;.
    /// </summary>
    [EnumMember(Value = "EF33")]
    [IsoId("_Algorithm29Code_EcfsdsaSha3_384")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcfsdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EF35&quot;.
    /// </summary>
    [EnumMember(Value = "EF35")]
    [IsoId("_Algorithm29Code_EcfsdsaSha3_512")]
    [Description(@"Elliptic Curve Full Schnorr Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.")]
    EcfsdsaSha3_512,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO22&quot;.
    /// </summary>
    [EnumMember(Value = "EO22")]
    [IsoId("_Algorithm29Code_EcosdsaSha256")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcosdsaSha256,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO23&quot;.
    /// </summary>
    [EnumMember(Value = "EO23")]
    [IsoId("_Algorithm29Code_EcosdsaSha384")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcosdsaSha384,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO25&quot;.
    /// </summary>
    [EnumMember(Value = "EO25")]
    [IsoId("_Algorithm29Code_EcosdsaSha512")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcosdsaSha512,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO32&quot;.
    /// </summary>
    [EnumMember(Value = "EO32")]
    [IsoId("_Algorithm29Code_EcosdaSha3_256")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcosdaSha3_256,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO33&quot;.
    /// </summary>
    [EnumMember(Value = "EO33")]
    [IsoId("_Algorithm29Code_EcosdsaSha3_384")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcosdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;EO35&quot;.
    /// </summary>
    [EnumMember(Value = "EO35")]
    [IsoId("_Algorithm29Code_EcosdsaSha3_512")]
    [Description(@"Elliptic Curve Optimised Schnorr Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.")]
    EcosdsaSha3_512,

    /// <summary>
    /// The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm.
    /// Encoded/decoded by serializers as &quot;ERS1&quot;.
    /// </summary>
    [EnumMember(Value = "ERS1")]
    [IsoId("_Algorithm29Code_SHA1WithRSA")]
    [Description(@"The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm.")]
    SHA1WithRSA = AlgorithmCode.SHA1WithRSA,

    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm.
    /// Encoded/decoded by serializers as &quot;ERS2&quot;.
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_Algorithm29Code_SHA256WithRSA")]
    [Description(@"Signature algorithms with RSA, using SHA-256 digest algorithm.")]
    SHA256WithRSA = AlgorithmCode.SHA256WithRSA,

    /// <summary>
    /// Signature algorithms with RSA, using SHA3-256 digest algorithm.
    /// Encoded/decoded by serializers as &quot;ERS3&quot;.
    /// </summary>
    [EnumMember(Value = "ERS3")]
    [IsoId("_Algorithm29Code_SHA3_256WithRSA")]
    [Description(@"Signature algorithms with RSA, using SHA3-256 digest algorithm.")]
    SHA3_256WithRSA = AlgorithmCode.SHA3_256WithRSA,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES22&quot;.
    /// </summary>
    [EnumMember(Value = "ES22")]
    [IsoId("_Algorithm29Code_EcsdsaSha256")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    EcsdsaSha256 = AlgorithmCode.EcsdsaSha256,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES23&quot;.
    /// </summary>
    [EnumMember(Value = "ES23")]
    [IsoId("_Algorithm29Code_EcsdsaSha384")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    EcsdsaSha384 = AlgorithmCode.EcsdsaSha384,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES25&quot;.
    /// </summary>
    [EnumMember(Value = "ES25")]
    [IsoId("_Algorithm29Code_EcsdsaSha512")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcsdsaSha512 = AlgorithmCode.EcsdsaSha512,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES32&quot;.
    /// </summary>
    [EnumMember(Value = "ES32")]
    [IsoId("_Algorithm29Code_EcsdaSha3_256")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    EcsdaSha3_256 = AlgorithmCode.EcsdaSha3_256,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES33&quot;.
    /// </summary>
    [EnumMember(Value = "ES33")]
    [IsoId("_Algorithm29Code_EcsdsaSha3_384")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    EcsdsaSha3_384 = AlgorithmCode.EcsdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES35&quot;.
    /// </summary>
    [EnumMember(Value = "ES35")]
    [IsoId("_Algorithm29Code_EcsdsaSha3_512")]
    [Description(@"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    EcsdsaSha3_512 = AlgorithmCode.EcsdsaSha3_512,

    /// <summary>
    /// Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1).
    /// Encoded/decoded by serializers as &quot;RPSS&quot;.
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_Algorithm29Code_RSASSA_PSS")]
    [Description(@"Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1).")]
    RSASSA_PSS = AlgorithmCode.RSASSA_PSS,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with ShangMi3 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;S2S3&quot;.
    /// </summary>
    [EnumMember(Value = "S2S3")]
    [IsoId("_Algorithm29Code_SM2SM3")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with ShangMi3 Digest Algorithm.")]
    SM2SM3,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM22&quot;.
    /// </summary>
    [EnumMember(Value = "SM22")]
    [IsoId("_Algorithm29Code_SM2Sha256")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.")]
    SM2Sha256,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM23&quot;.
    /// </summary>
    [EnumMember(Value = "SM23")]
    [IsoId("_Algorithm29Code_SM2Sha384")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.")]
    SM2Sha384,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM25&quot;.
    /// </summary>
    [EnumMember(Value = "SM25")]
    [IsoId("_Algorithm29Code_SM2Sha512")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.")]
    SM2Sha512,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM32&quot;.
    /// </summary>
    [EnumMember(Value = "SM32")]
    [IsoId("_Algorithm29Code_SM2Sha3_256")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.")]
    SM2Sha3_256,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM33&quot;.
    /// </summary>
    [EnumMember(Value = "SM33")]
    [IsoId("_Algorithm29Code_SM2Sha3_384")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.")]
    SM2Sha3_384,

    /// <summary>
    /// ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;SM35&quot;.
    /// </summary>
    [EnumMember(Value = "SM35")]
    [IsoId("_Algorithm29Code_SM2Sha3_512")]
    [Description(@"ShangMi2 Elliptic Curve Digital Signature Algorithm coupled with SHA3-512 Digest Algorithm.")]
    SM2Sha3_512,

}
