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
/// Features of a media resource.
/// </summary>
[IsoId("_wkqgEC8DEeu125Ip9zFcsQ")]
[DisplayName("Resource Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResourceContent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResourceContent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResourceContent1( ResourceType1Code reqResourceType )
    {
        ResourceType = reqResourceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of media resource.
    /// </summary>
    [IsoId("_RZ53wC8EEeu125Ip9zFcsQ")]
    [DisplayName("Resource Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsrcTp")]
    #endif
    [IsoXmlTag("RsrcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResourceType1Code ResourceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResourceType1Code ResourceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResourceType1Code ResourceType { get; init; } 
    #else
    public ResourceType1Code ResourceType { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the media resource;
    /// </summary>
    [IsoId("_X5H98C8EEeu125Ip9zFcsQ")]
    [DisplayName("Resource Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsrcFrmt")]
    #endif
    [IsoXmlTag("RsrcFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SoundFormat1Code? ResourceFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SoundFormat1Code? ResourceFormat { get; init; } 
    #else
    public SoundFormat1Code? ResourceFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the media resource.
    /// </summary>
    [IsoId("_fjS0UC8EEeu125Ip9zFcsQ")]
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
    /// Reference of a media resource.
    /// </summary>
    [IsoId("_bzU3wS8GEeu125Ip9zFcsQ")]
    [DisplayName("Resource Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsrcRef")]
    #endif
    [IsoXmlTag("RsrcRef")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? ResourceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResourceReference { get; init; } 
    #else
    public System.String? ResourceReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
