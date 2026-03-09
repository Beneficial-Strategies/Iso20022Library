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
/// Details of a contact person.
/// </summary>
[IsoId("_4-TwPfM4Eei4qfiLgRIZBA")]
[DisplayName("Contact")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Contact3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Central phone number for the contact.
    /// </summary>
    [IsoId("_4-UXSPM4Eei4qfiLgRIZBA")]
    [DisplayName("Central Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrlPhneNb")]
    #endif
    [IsoXmlTag("CntrlPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? CentralPhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CentralPhoneNumber { get; init; } 
    #else
    public System.String? CentralPhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Property phone number for the contact.
    /// </summary>
    [IsoId("_4-TwPvM4Eei4qfiLgRIZBA")]
    [DisplayName("Property Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrprtyPhneNb")]
    #endif
    [IsoXmlTag("PrprtyPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? PropertyPhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PropertyPhoneNumber { get; init; } 
    #else
    public System.String? PropertyPhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Toll-free phone number for the contact.
    /// </summary>
    [IsoId("_4-UXQ_M4Eei4qfiLgRIZBA")]
    [DisplayName("Toll Free Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TollFreePhneNb")]
    #endif
    [IsoXmlTag("TollFreePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? TollFreePhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TollFreePhoneNumber { get; init; } 
    #else
    public System.String? TollFreePhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Email address of contact.
    /// </summary>
    [IsoId("_4-UXSvM4Eei4qfiLgRIZBA")]
    [DisplayName("Email")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Email")]
    #endif
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Email { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Email { get; init; } 
    #else
    public System.String? Email { get; set; } 
    #endif
    
    /// <summary>
    /// Fax phone number.
    /// </summary>
    [IsoId("_4-UXRvM4Eei4qfiLgRIZBA")]
    [DisplayName("Fax Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaxNb")]
    #endif
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? FaxNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FaxNumber { get; init; } 
    #else
    public System.String? FaxNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_4-UXQPM4Eei4qfiLgRIZBA")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_4-UXQfM4Eei4qfiLgRIZBA")]
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
    
    
    #nullable disable
    
}
