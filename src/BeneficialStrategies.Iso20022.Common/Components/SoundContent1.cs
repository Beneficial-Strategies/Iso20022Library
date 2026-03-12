// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Sound to play.
/// </summary>
[IsoId("_2WDDcN6-Eeiwsev40qZGEQ")]
[DisplayName("Sound Content")]
public partial record SoundContent1
{
    #nullable enable
    
    /// <summary>
    /// Type of sound to play, as a reference to a sound, a reference to a Message, or a Text to read.
    /// </summary>
    [IsoId("_8SaUMN6-Eeiwsev40qZGEQ")]
    [DisplayName("Sound Format")]
    [IsoXmlTag("SoundFrmt")]
    public required SoundFormat1Code SoundFormat { get; init; } 
    
    /// <summary>
    /// Language of the text to play if Text-To-Speech is used.
    /// </summary>
    [IsoId("_WA1aMN6_Eeiwsev40qZGEQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Reference of a predefined message to play (Sound or text file name, URL, etc.).
    /// </summary>
    [IsoId("_aSHpMN6_Eeiwsev40qZGEQ")]
    [DisplayName("Sound Reference")]
    [IsoXmlTag("SoundRef")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? SoundReference { get; init; } 
    
    /// <summary>
    /// Content of text message to play (Text-to-Speech).
    /// </summary>
    [IsoId("_dWbHsN6_Eeiwsev40qZGEQ")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? Text { get; init; } 
    
    
    #nullable disable
    
}
