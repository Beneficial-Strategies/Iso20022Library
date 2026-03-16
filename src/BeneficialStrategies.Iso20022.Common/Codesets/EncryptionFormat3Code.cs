// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ODabcNZ1EeeA4_YxLuyJaA")]
[Description(@"Format of data before encryption, if the format is not plaintext or implicit.")]
[DerivedFrom(typeof(EncryptionFormatCode))]
public enum EncryptionFormat3Code
{
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-34 standard.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_KlXRgX0lEemfrNOe0zHQyg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-34 standard.")]
    TR34 = EncryptionFormatCode.TR34, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-31 standard.
    /// Encoded/decoded by serializers as &quot;TR31&quot;.
    /// </summary>
    [EnumMember(Value = "TR31")]
    [IsoId("_KlXRg30lEemfrNOe0zHQyg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-31 standard.")]
    TR31 = EncryptionFormatCode.TR31, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CTC encryption mode.
    /// Encoded/decoded by serializers as &quot;CTCE&quot;.
    /// </summary>
    [EnumMember(Value = "CTCE")]
    [IsoId("_KlXRhX0lEemfrNOe0zHQyg")]
    [Description(@"CTC encryption mode.")]
    CTCE = EncryptionFormatCode.CTCE, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cipher Block Chaining mode of encryption
    /// Encoded/decoded by serializers as &quot;CBCE&quot;.
    /// </summary>
    [EnumMember(Value = "CBCE")]
    [IsoId("_KlXRh30lEemfrNOe0zHQyg")]
    [Description(@"Cipher Block Chaining mode of encryption")]
    CBC = EncryptionFormatCode.CBC, // same ordinal as derivation source for type conversions
}
