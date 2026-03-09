// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for encryptions with a symmetric cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-7tyIWjBEeSP8Z8nx8HTuQ")]
[Description(@"Cryptographic algorithms for encryptions with a symmetric cryptographic key.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm15Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("__IaKUWjBEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128CBC = AlgorithmCode.AES128CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("__IaKU2jBEeSP8Z8nx8HTuQ")]
    [Description(@"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).")]
    DES112CBC = AlgorithmCode.DES112CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_DT3eIWjCEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES192CBC = AlgorithmCode.AES192CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_DeJbgWjCEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES256CBC = AlgorithmCode.AES256CBC, // same ordinal as derivation source for type conversions
    
}
