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
[IsoId("_ge_TAdaCEeeA4_YxLuyJaA")]
[Description(@"Cryptographic algorithms for encryptions with a symmetric cryptographic key.")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm23Code>))]
#endif
public enum Algorithm23Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_WsvvgX0kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CBC = AlgorithmCode.AES128CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_Wsvvg30kEemfrNOe0zHQyg")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES112CBC = AlgorithmCode.DES112CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_WsvvhX0kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CBC = AlgorithmCode.AES192CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_Wsvvh30kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CBC = AlgorithmCode.AES256CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2R&quot;.
    /// </summary>
    [EnumMember(Value = "EA2R")]
    [IsoId("_WsvviX0kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CTR = AlgorithmCode.AES128CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9R&quot;.
    /// </summary>
    [EnumMember(Value = "EA9R")]
    [IsoId("_Wsvvi30kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CTR = AlgorithmCode.AES192CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5R&quot;.
    /// </summary>
    [EnumMember(Value = "EA5R")]
    [IsoId("_WsvvjX0kEemfrNOe0zHQyg")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CTR = AlgorithmCode.AES256CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E3DR&quot;.
    /// </summary>
    [EnumMember(Value = "E3DR")]
    [IsoId("_Wsvvj30kEemfrNOe0zHQyg")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a."
    )]
    DES112CTR = AlgorithmCode.DES112CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E36C&quot;.
    /// </summary>
    [EnumMember(Value = "E36C")]
    [IsoId("_WsvvkX0kEemfrNOe0zHQyg")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES168CBC = AlgorithmCode.DES168CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E36R&quot;.
    /// </summary>
    [EnumMember(Value = "E36R")]
    [IsoId("_Wsvvk30kEemfrNOe0zHQyg")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a."
    )]
    DES168CTR = AlgorithmCode.DES168CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc).
    /// Encoded/decoded by serializers as &quot;SD5C&quot;.
    /// </summary>
    [EnumMember(Value = "SD5C")]
    [IsoId("_WsvvlX0kEemfrNOe0zHQyg")]
    [Description(
        @"The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc)."
    )]
    SDE056CBC = AlgorithmCode.SDE056CBC, // same ordinal as derivation source for type conversions
}
