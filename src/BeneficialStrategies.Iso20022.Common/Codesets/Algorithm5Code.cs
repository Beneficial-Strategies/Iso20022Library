// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digests.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t3fDoAitEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for digests.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm5Code
{
    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as &quot;HS25&quot;.
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_yzqpwQitEeKn9O5oyej_zw")]
    [Description(@"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).")]
    SHA256 = AlgorithmCode.SHA256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as &quot;HS38&quot;.
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_zti4EQitEeKn9O5oyej_zw")]
    [Description(@"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).")]
    SHA384 = AlgorithmCode.SHA384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as &quot;HS51&quot;.
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_z4_6IQitEeKn9O5oyej_zw")]
    [Description(@"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).")]
    SHA512 = AlgorithmCode.SHA512, // same ordinal as derivation source for type conversions
    
}
