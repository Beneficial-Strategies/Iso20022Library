// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for encryptions with a symmetric cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tw6sIAiuEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for encryptions with a symmetric cryptographic key.")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm6Code>))]
#endif
public enum Algorithm6Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_1z-joQiuEeKn9O5oyej_zw")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CBC = AlgorithmCode.AES128CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_2AxCcwiuEeKn9O5oyej_zw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES112CBC = AlgorithmCode.DES112CBC, // same ordinal as derivation source for type conversions
}
