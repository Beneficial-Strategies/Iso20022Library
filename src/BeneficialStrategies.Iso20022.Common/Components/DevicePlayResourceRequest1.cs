// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Play Request message.
/// </summary>
[IsoId("_3pwzIC8GEeu125Ip9zFcsQ")]
[DisplayName("Device Play Resource Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePlayResourceRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DevicePlayResourceRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DevicePlayResourceRequest1( ResourceAction1Code reqResourceAction )
    {
        ResourceAction = reqResourceAction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message response awaited by the initiator of the Request.
    /// </summary>
    [IsoId("_XQLAMS8HEeu125Ip9zFcsQ")]
    [DisplayName("Response Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnMd")]
    #endif
    [IsoXmlTag("RspnMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseMode2Code? ResponseMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseMode2Code? ResponseMode { get; init; } 
    #else
    public ResponseMode2Code? ResponseMode { get; set; } 
    #endif
    
    /// <summary>
    /// Requested Action: Start to play a media resource, Stop to play a media resource, Set the default volume.
    /// </summary>
    [IsoId("_u_G6sy8HEeu125Ip9zFcsQ")]
    [DisplayName("Resource Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsrcActn")]
    #endif
    [IsoXmlTag("RsrcActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResourceAction1Code ResourceAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResourceAction1Code ResourceAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResourceAction1Code ResourceAction { get; init; } 
    #else
    public ResourceAction1Code ResourceAction { get; set; } 
    #endif
    
    /// <summary>
    /// Volume of a sound, either in a percentage of the maximum volume, or 0 to mute.
    /// </summary>
    [IsoId("_u_G6tC8HEeu125Ip9zFcsQ")]
    [DisplayName("Sound Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SoundVol")]
    #endif
    [IsoXmlTag("SoundVol")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? SoundVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SoundVolume { get; init; } 
    #else
    public System.Decimal? SoundVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Resolution to use.
    /// </summary>
    [IsoId("_JPIR4C8IEeu125Ip9zFcsQ")]
    [DisplayName("Display Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispRsltn")]
    #endif
    [IsoXmlTag("DispRsltn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DisplayResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisplayResolution { get; init; } 
    #else
    public System.String? DisplayResolution { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the resource to use.
    /// </summary>
    [IsoId("_u_G6tS8HEeu125Ip9zFcsQ")]
    [DisplayName("Resource")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsrc")]
    #endif
    [IsoXmlTag("Rsrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResourceContent1? Resource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResourceContent1? Resource { get; init; } 
    #else
    public ResourceContent1? Resource { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the moment to manage the media resource.
    /// </summary>
    [IsoId("_vqtnAC8IEeu125Ip9zFcsQ")]
    [DisplayName("Timing Slot")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmgSlot")]
    #endif
    [IsoXmlTag("TmgSlot")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition2Code? TimingSlot { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition2Code? TimingSlot { get; init; } 
    #else
    public ProcessingPosition2Code? TimingSlot { get; set; } 
    #endif
    
    
    #nullable disable
    
}
