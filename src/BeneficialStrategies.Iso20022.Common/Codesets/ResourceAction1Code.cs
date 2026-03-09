// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on a media resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YO9n4C8AEeu125Ip9zFcsQ")]
[Description(@"Type of action to perform on a media resource.")]
[DerivedFrom(typeof(ResourceActionCode))]
public enum ResourceAction1Code
{
    /// <summary>
    /// Pause the media resource in progress as specified in the message.
    /// Encoded/decoded by serializers as &quot;PAUS&quot;.
    /// </summary>
    [EnumMember(Value = "PAUS")]
    [IsoId("_Zlf9AS8AEeu125Ip9zFcsQ")]
    [Description(@"Pause the media resource in progress as specified in the message.")]
    Pause = ResourceActionCode.Pause, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Start the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;STAS&quot;.
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_ZpxZAS8AEeu125Ip9zFcsQ")]
    [Description(@"Start the media resource as specified in the message.")]
    Play = ResourceActionCode.Play, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Play in a loop the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;LOOP&quot;.
    /// </summary>
    [EnumMember(Value = "LOOP")]
    [IsoId("_Zu6XsS8AEeu125Ip9zFcsQ")]
    [Description(@"Play in a loop the media resource as specified in the message.")]
    PlayInLoop = ResourceActionCode.PlayInLoop, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Resume the progress of the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_ZzjAES8AEeu125Ip9zFcsQ")]
    [Description(@"Resume the progress of the media resource as specified in the message.")]
    Resume = ResourceActionCode.Resume, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Set the default volume of sounds.
    /// Encoded/decoded by serializers as &quot;DVOL&quot;.
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_Z4VZcS8AEeu125Ip9zFcsQ")]
    [Description(@"Set the default volume of sounds.")]
    SetDefaultVolume = ResourceActionCode.SetDefaultVolume, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop the media resource in progress.
    /// Encoded/decoded by serializers as &quot;STOS&quot;.
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_Z9HLwS8AEeu125Ip9zFcsQ")]
    [Description(@"Stop the media resource in progress.")]
    Stop = ResourceActionCode.Stop, // same ordinal as derivation source for type conversions
    
}
