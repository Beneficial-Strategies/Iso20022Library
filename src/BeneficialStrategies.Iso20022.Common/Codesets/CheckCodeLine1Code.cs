// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of the check code line.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ecCDMK4EEeWL1uap3dNhCQ")]
[Description(@"Format of the check code line.")]
[DerivedFrom(typeof(CheckCodeLineCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CheckCodeLine1Code>))]
#endif
public enum CheckCodeLine1Code
{
    /// <summary>
    /// Magnetic ink character digitally encoded with 7 sticks.
    /// Encoded/decoded by serializers as &quot;CMC7&quot;.
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_jJnMoa4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character digitally encoded with 7 sticks.")]
    CMC7 = CheckCodeLineCode.CMC7, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic ink character recognition., conform to ISO 1004.
    /// Encoded/decoded by serializers as &quot;E13B&quot;.
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_jRgkY64EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character recognition., conform to ISO 1004.")]
    E13B = CheckCodeLineCode.E13B, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Optical character recognition font A, conform to ANSI X3.17: 1981.
    /// Encoded/decoded by serializers as &quot;OCRA&quot;.
    /// </summary>
    [EnumMember(Value = "OCRA")]
    [IsoId("_jTceEa4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font A, conform to ANSI X3.17: 1981.")]
    OCRA = CheckCodeLineCode.OCRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Optical character recognition font B, conform to ANSI X3.49: 1975.
    /// Encoded/decoded by serializers as &quot;OCRB&quot;.
    /// </summary>
    [EnumMember(Value = "OCRB")]
    [IsoId("_jYqVQa4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font B, conform to ANSI X3.49: 1975.")]
    OCRB = CheckCodeLineCode.OCRB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default optical character recognition used.
    /// Encoded/decoded by serializers as &quot;OCRF&quot;.
    /// </summary>
    [EnumMember(Value = "OCRF")]
    [IsoId("_jjGDo64EEeWL1uap3dNhCQ")]
    [Description(@"Default optical character recognition used.")]
    OCRDefault = CheckCodeLineCode.OCRDefault, // same ordinal as derivation source for type conversions
}
