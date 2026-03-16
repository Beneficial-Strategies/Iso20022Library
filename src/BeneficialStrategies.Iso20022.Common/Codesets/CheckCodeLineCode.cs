// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of the check code line.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JUeaoK4EEeWL1uap3dNhCQ")]
[Description(@"Format of the check code line.")]
[Derivations(typeof(CheckCodeLine1Code))]
public enum CheckCodeLineCode
{
    /// <summary>
    /// Magnetic ink character digitally encoded with 7 sticks.
    /// Encoded/decoded by serializers as &quot;CMC7&quot;.
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_O9mmUK4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character digitally encoded with 7 sticks.")]
    CMC7,

    /// <summary>
    /// Magnetic ink character recognition., conform to ISO 1004.
    /// Encoded/decoded by serializers as &quot;E13B&quot;.
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_RxecIK4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character recognition., conform to ISO 1004.")]
    E13B,

    /// <summary>
    /// Optical character recognition font A, conform to ANSI X3.17: 1981.
    /// Encoded/decoded by serializers as &quot;OCRA&quot;.
    /// </summary>
    [EnumMember(Value = "OCRA")]
    [IsoId("_UH3rwK4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font A, conform to ANSI X3.17: 1981.")]
    OCRA,

    /// <summary>
    /// Optical character recognition font B, conform to ANSI X3.49: 1975.
    /// Encoded/decoded by serializers as &quot;OCRB&quot;.
    /// </summary>
    [EnumMember(Value = "OCRB")]
    [IsoId("_Wpt9cK4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font B, conform to ANSI X3.49: 1975.")]
    OCRB,

    /// <summary>
    /// Default optical character recognition used.
    /// Encoded/decoded by serializers as &quot;OCRF&quot;.
    /// </summary>
    [EnumMember(Value = "OCRF")]
    [IsoId("_ZSIxMK4EEeWL1uap3dNhCQ")]
    [Description(@"Default optical character recognition used.")]
    OCRDefault,
}
