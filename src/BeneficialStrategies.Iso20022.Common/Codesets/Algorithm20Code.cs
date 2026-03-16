// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EGOq0aRHEeeWXKXf3KjtmQ")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm20Code
{
    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as &quot;HS25&quot;.
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_ER020aRHEeeWXKXf3KjtmQ")]
    [Description(
        @"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256)."
    )]
    SHA256 = AlgorithmCode.SHA256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as &quot;HS38&quot;.
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_ER0206RHEeeWXKXf3KjtmQ")]
    [Description(
        @"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384)."
    )]
    SHA384 = AlgorithmCode.SHA384, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as &quot;HS51&quot;.
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_ER021aRHEeeWXKXf3KjtmQ")]
    [Description(
        @"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512)."
    )]
    SHA512 = AlgorithmCode.SHA512, // same ordinal as derivation source for type conversions
}
