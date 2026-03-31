// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on the sound.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pB5s0N6-Eeiwsev40qZGEQ")]
[Description(@"Type of action to perform on the sound.")]
[DerivedFrom(typeof(SoundActionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SoundAction1Code>))]
#endif
public enum SoundAction1Code
{
    /// <summary>
    /// Set the default volume of sounds.
    /// Encoded/decoded by serializers as &quot;DVOL&quot;.
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_qbO3Qd6-Eeiwsev40qZGEQ")]
    [Description(@"Set the default volume of sounds.")]
    SetDefaultVolume = SoundActionCode.SetDefaultVolume, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Start the sound as specified in the message.
    /// Encoded/decoded by serializers as &quot;STAS&quot;.
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_qhPYoN6-Eeiwsev40qZGEQ")]
    [Description(@"Start the sound as specified in the message.")]
    StartSound = SoundActionCode.StartSound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stop the sound in progress.
    /// Encoded/decoded by serializers as &quot;STOS&quot;.
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_qkcdod6-Eeiwsev40qZGEQ")]
    [Description(@"Stop the sound in progress.")]
    StopSound = SoundActionCode.StopSound, // same ordinal as derivation source for type conversions
}
