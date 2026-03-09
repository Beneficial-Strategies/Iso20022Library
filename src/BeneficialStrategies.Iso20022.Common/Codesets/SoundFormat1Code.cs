// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of sound to play.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MjnR0N6_Eeiwsev40qZGEQ")]
[Description(@"Type of sound to play.")]
[DerivedFrom(typeof(SoundFormatCode))]
public enum SoundFormat1Code
{
    /// <summary>
    /// Reference of a preloaded text to play.
    /// Encoded/decoded by serializers as &quot;MSGR&quot;.
    /// </summary>
    [EnumMember(Value = "MSGR")]
    [IsoId("_OeHPod6_Eeiwsev40qZGEQ")]
    [Description(@"Reference of a preloaded text to play.")]
    MessageRef = SoundFormatCode.MessageRef, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preloaded sound File.
    /// Encoded/decoded by serializers as &quot;SNDR&quot;.
    /// </summary>
    [EnumMember(Value = "SNDR")]
    [IsoId("_OhkMQd6_Eeiwsev40qZGEQ")]
    [Description(@"Preloaded sound File.")]
    SoundRef = SoundFormatCode.SoundRef, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Text to play.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_OlZjYd6_Eeiwsev40qZGEQ")]
    [Description(@"Text to play.")]
    Text = SoundFormatCode.Text, // same ordinal as derivation source for type conversions
    
}
