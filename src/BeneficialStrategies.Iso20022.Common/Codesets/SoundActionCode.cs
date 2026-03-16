// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on the sound.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WrnSAN6-Eeiwsev40qZGEQ")]
[Description(@"Type of action to perform on the sound.")]
[Derivations(typeof(SoundAction1Code))]
public enum SoundActionCode
{
    /// <summary>
    /// Start the sound as specified in the message.
    /// Encoded/decoded by serializers as &quot;STAS&quot;.
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_fGWpsN6-Eeiwsev40qZGEQ")]
    [Description(@"Start the sound as specified in the message.")]
    StartSound,

    /// <summary>
    /// Stop the sound in progress.
    /// Encoded/decoded by serializers as &quot;STOS&quot;.
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_hr_PMN6-Eeiwsev40qZGEQ")]
    [Description(@"Stop the sound in progress.")]
    StopSound,

    /// <summary>
    /// Set the default volume of sounds.
    /// Encoded/decoded by serializers as &quot;DVOL&quot;.
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_kdmbMN6-Eeiwsev40qZGEQ")]
    [Description(@"Set the default volume of sounds.")]
    SetDefaultVolume,
}
