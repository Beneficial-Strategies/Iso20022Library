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
/// Content of the Sound Request message.
/// </summary>
[IsoId("_GGvxgN6-Eeiwsev40qZGEQ")]
[DisplayName("Device Play Sound Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePlaySoundRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DevicePlaySoundRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DevicePlaySoundRequest1( SoundAction1Code reqSoundAction )
    {
        SoundAction = reqSoundAction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message response awaited by the initiator of the Request.
    /// </summary>
    [IsoId("_Qx_MMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Response Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnMd")]
    #endif
    [IsoXmlTag("RspnMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseMode1Code? ResponseMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseMode1Code? ResponseMode { get; init; } 
    #else
    public ResponseMode1Code? ResponseMode { get; set; } 
    #endif
    
    /// <summary>
    /// Requested Action: Start to play a sound, Stop to play a sound, Set the default volume.
    /// </summary>
    [IsoId("_VPocMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SoundActn")]
    #endif
    [IsoXmlTag("SoundActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SoundAction1Code SoundAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SoundAction1Code SoundAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SoundAction1Code SoundAction { get; init; } 
    #else
    public SoundAction1Code SoundAction { get; set; } 
    #endif
    
    /// <summary>
    /// Volume of a sound, either in a pourcentage of the maximum volume, or 0 to mute.
    /// </summary>
    [IsoId("_xG7TMN6-Eeiwsev40qZGEQ")]
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
    /// Content of a sound to play.
    /// </summary>
    [IsoId("_z4YuMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SoundCntt")]
    #endif
    [IsoXmlTag("SoundCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SoundContent1? SoundContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SoundContent1? SoundContent { get; init; } 
    #else
    public SoundContent1? SoundContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
