// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of sound to play.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ADcV0N6_Eeiwsev40qZGEQ")]
[Description(@"Type of sound to play.")]
[Derivations(typeof(SoundFormat1Code))]
public enum SoundFormatCode
{
    /// <summary>
    /// Preloaded sound File.
    /// Encoded/decoded by serializers as &quot;SNDR&quot;.
    /// </summary>
    [EnumMember(Value = "SNDR")]
    [IsoId("_Dn7JMN6_Eeiwsev40qZGEQ")]
    [Description(@"Preloaded sound File.")]
    SoundRef,
    
    /// <summary>
    /// Reference of a preloaded text to play.
    /// Encoded/decoded by serializers as &quot;MSGR&quot;.
    /// </summary>
    [EnumMember(Value = "MSGR")]
    [IsoId("_F6QYMN6_Eeiwsev40qZGEQ")]
    [Description(@"Reference of a preloaded text to play.")]
    MessageRef,
    
    /// <summary>
    /// Text to play.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_IaHF0N6_Eeiwsev40qZGEQ")]
    [Description(@"Text to play.")]
    Text,
    
}
