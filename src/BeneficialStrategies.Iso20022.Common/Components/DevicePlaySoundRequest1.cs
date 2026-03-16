// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Sound Request message.
/// </summary>
[IsoId("_GGvxgN6-Eeiwsev40qZGEQ")]
[DisplayName("Device Play Sound Request")]
public record DevicePlaySoundRequest1
{
    /// <summary>
    /// Message response awaited by the initiator of the Request.
    /// </summary>
    [IsoId("_Qx_MMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public ResponseMode1Code? ResponseMode { get; init; }

    /// <summary>
    /// Requested Action: Start to play a sound, Stop to play a sound, Set the default volume.
    /// </summary>
    [IsoId("_VPocMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Action")]
    [IsoXmlTag("SoundActn")]
    public required SoundAction1Code SoundAction { get; init; }

    /// <summary>
    /// Volume of a sound, either in a pourcentage of the maximum volume, or 0 to mute.
    /// </summary>
    [IsoId("_xG7TMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Volume")]
    [IsoXmlTag("SoundVol")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? SoundVolume { get; init; }

    /// <summary>
    /// Content of a sound to play.
    /// </summary>
    [IsoId("_z4YuMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Content")]
    [IsoXmlTag("SoundCntt")]
    public SoundContent1? SoundContent { get; init; }
}
