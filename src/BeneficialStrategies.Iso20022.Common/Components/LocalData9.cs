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
/// Contains text fields in the local language.
/// </summary>
[IsoId("_TWMJsTNMEeylu6lH-gut-A")]
[DisplayName("Local Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalData9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalData9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalData9( string reqLanguage,System.String reqTextMessage )
    {
        Language = reqLanguage;
        TextMessage = reqTextMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_Tc-HITNMEeylu6lH-gut-A")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISOMax3ALanguageCode Language { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Language { get; init; } 
    #else
    public string Language { get; set; } 
    #endif
    
    /// <summary>
    /// Contains generic text message in local language.
    /// </summary>
    [IsoId("_fXKBMDNMEeylu6lH-gut-A")]
    [DisplayName("Text Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxtMsg")]
    #endif
    [IsoXmlTag("TxtMsg")]
    [IsoSimpleType(IsoSimpleType.Max40KText)]
    [StringLength(maximumLength: 40000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax40KText TextMessage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TextMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TextMessage { get; init; } 
    #else
    public System.String TextMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
