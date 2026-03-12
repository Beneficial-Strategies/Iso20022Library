// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Play Request message.
/// </summary>
[IsoId("_3pwzIC8GEeu125Ip9zFcsQ")]
[DisplayName("Device Play Resource Request")]
public partial record DevicePlayResourceRequest1
{
    #nullable enable
    
    /// <summary>
    /// Message response awaited by the initiator of the Request.
    /// </summary>
    [IsoId("_XQLAMS8HEeu125Ip9zFcsQ")]
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public ResponseMode2Code? ResponseMode { get; init; } 
    
    /// <summary>
    /// Requested Action: Start to play a media resource, Stop to play a media resource, Set the default volume.
    /// </summary>
    [IsoId("_u_G6sy8HEeu125Ip9zFcsQ")]
    [DisplayName("Resource Action")]
    [IsoXmlTag("RsrcActn")]
    public required ResourceAction1Code ResourceAction { get; init; } 
    
    /// <summary>
    /// Volume of a sound, either in a percentage of the maximum volume, or 0 to mute.
    /// </summary>
    [IsoId("_u_G6tC8HEeu125Ip9zFcsQ")]
    [DisplayName("Sound Volume")]
    [IsoXmlTag("SoundVol")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? SoundVolume { get; init; } 
    
    /// <summary>
    /// Resolution to use.
    /// </summary>
    [IsoId("_JPIR4C8IEeu125Ip9zFcsQ")]
    [DisplayName("Display Resolution")]
    [IsoXmlTag("DispRsltn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DisplayResolution { get; init; } 
    
    /// <summary>
    /// Identification of the resource to use.
    /// </summary>
    [IsoId("_u_G6tS8HEeu125Ip9zFcsQ")]
    [DisplayName("Resource")]
    [IsoXmlTag("Rsrc")]
    public ResourceContent1? Resource { get; init; } 
    
    /// <summary>
    /// Identification of the moment to manage the media resource.
    /// </summary>
    [IsoId("_vqtnAC8IEeu125Ip9zFcsQ")]
    [DisplayName("Timing Slot")]
    [IsoXmlTag("TmgSlot")]
    public ProcessingPosition2Code? TimingSlot { get; init; } 
    
    
    #nullable disable
    
}
