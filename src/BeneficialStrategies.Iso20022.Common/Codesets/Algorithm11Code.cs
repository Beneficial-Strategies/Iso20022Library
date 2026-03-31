// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x-PlMWi4EeS87LmvcA55sg")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm11Code>))]
#endif
public enum Algorithm11Code
{
    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as &quot;HS25&quot;.
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_yLO4UWi4EeS87LmvcA55sg")]
    [Description(
        @"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256)."
    )]
    SHA256 = AlgorithmCode.SHA256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as &quot;HS38&quot;.
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_yLO4U2i4EeS87LmvcA55sg")]
    [Description(
        @"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384)."
    )]
    SHA384 = AlgorithmCode.SHA384, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as &quot;HS51&quot;.
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_yLO4VWi4EeS87LmvcA55sg")]
    [Description(
        @"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512)."
    )]
    SHA512 = AlgorithmCode.SHA512, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1).
    /// Encoded/decoded by serializers as &quot;HS01&quot;.
    /// </summary>
    [EnumMember(Value = "HS01")]
    [IsoId("_I6AWUWi5EeS87LmvcA55sg")]
    [Description(
        @"The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1)."
    )]
    SHA1 = AlgorithmCode.SHA1, // same ordinal as derivation source for type conversions
}
