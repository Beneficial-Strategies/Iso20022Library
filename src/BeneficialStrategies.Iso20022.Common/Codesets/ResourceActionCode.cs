// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on a media resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LI9QYC7_Eeu125Ip9zFcsQ")]
[Description(@"Type of action to perform on a media resource.")]
[Derivations(typeof(ResourceAction1Code))]
public enum ResourceActionCode
{
    /// <summary>
    /// Set the default volume of sounds.
    /// Encoded/decoded by serializers as &quot;DVOL&quot;.
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_f977MS7_Eeu125Ip9zFcsQ")]
    [Description(@"Set the default volume of sounds.")]
    SetDefaultVolume,
    
    /// <summary>
    /// Start the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;STAS&quot;.
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_mCpPoS7_Eeu125Ip9zFcsQ")]
    [Description(@"Start the media resource as specified in the message.")]
    Play,
    
    /// <summary>
    /// Play in a loop the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;LOOP&quot;.
    /// </summary>
    [EnumMember(Value = "LOOP")]
    [IsoId("_m1zK4S7_Eeu125Ip9zFcsQ")]
    [Description(@"Play in a loop the media resource as specified in the message.")]
    PlayInLoop,
    
    /// <summary>
    /// Stop the media resource in progress.
    /// Encoded/decoded by serializers as &quot;STOS&quot;.
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_89VCsS7_Eeu125Ip9zFcsQ")]
    [Description(@"Stop the media resource in progress.")]
    Stop,
    
    /// <summary>
    /// Pause the media resource in progress as specified in the message.
    /// Encoded/decoded by serializers as &quot;PAUS&quot;.
    /// </summary>
    [EnumMember(Value = "PAUS")]
    [IsoId("_DYgWYS8AEeu125Ip9zFcsQ")]
    [Description(@"Pause the media resource in progress as specified in the message.")]
    Pause,
    
    /// <summary>
    /// Resume the progress of the media resource as specified in the message.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_D5h_0S8AEeu125Ip9zFcsQ")]
    [Description(@"Resume the progress of the media resource as specified in the message.")]
    Resume,
    
}
