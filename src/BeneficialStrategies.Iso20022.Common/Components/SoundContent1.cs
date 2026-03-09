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
/// Content of the Sound to play.
/// </summary>
[IsoId("_2WDDcN6-Eeiwsev40qZGEQ")]
[DisplayName("Sound Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SoundContent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SoundContent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SoundContent1( SoundFormat1Code reqSoundFormat )
    {
        SoundFormat = reqSoundFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of sound to play, as a reference to a sound, a reference to a Message, or a Text to read.
    /// </summary>
    [IsoId("_8SaUMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SoundFrmt")]
    #endif
    [IsoXmlTag("SoundFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SoundFormat1Code SoundFormat { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SoundFormat1Code SoundFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SoundFormat1Code SoundFormat { get; init; } 
    #else
    public SoundFormat1Code SoundFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the text to play if Text-To-Speech is used.
    /// </summary>
    [IsoId("_WA1aMN6_Eeiwsev40qZGEQ")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of a predefined message to play (Sound or text file name, URL, etc.).
    /// </summary>
    [IsoId("_aSHpMN6_Eeiwsev40qZGEQ")]
    [DisplayName("Sound Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SoundRef")]
    #endif
    [IsoXmlTag("SoundRef")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? SoundReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SoundReference { get; init; } 
    #else
    public System.String? SoundReference { get; set; } 
    #endif
    
    /// <summary>
    /// Content of text message to play (Text-to-Speech).
    /// </summary>
    [IsoId("_dWbHsN6_Eeiwsev40qZGEQ")]
    [DisplayName("Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txt")]
    #endif
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? Text { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Text { get; init; } 
    #else
    public System.String? Text { get; set; } 
    #endif
    
    
    #nullable disable
    
}
