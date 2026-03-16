// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-frYEdtnEee9e6xduATmQg")]
[Description(@"Format of data before encryption, if the format is not plaintext or implicit.")]
[DerivedFrom(typeof(EncryptionFormatCode))]
public enum EncryptionFormat2Code
{
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-31 standard.
    /// Encoded/decoded by serializers as &quot;TR31&quot;.
    /// </summary>
    [EnumMember(Value = "TR31")]
    [IsoId("_-pI2EdtnEee9e6xduATmQg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-31 standard.")]
    TR31 = EncryptionFormatCode.TR31, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-34 standard.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_-pI2E9tnEee9e6xduATmQg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-34 standard.")]
    TR34 = EncryptionFormatCode.TR34, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of a cryptographic key specified by the ISO20038 standard.
    /// Encoded/decoded by serializers as &quot;I238&quot;.
    /// </summary>
    [EnumMember(Value = "I238")]
    [IsoId("__uLLgdtnEee9e6xduATmQg")]
    [Description(@"Format of a cryptographic key specified by the ISO20038 standard.")]
    ISO20038KeyWrap = EncryptionFormatCode.ISO20038KeyWrap, // same ordinal as derivation source for type conversions
}
