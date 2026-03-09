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
[IsoId("_DZOUkVyuEeeve7Je9cXtkQ")]
[DisplayName("Contact")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Contact2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_DkrWoVyuEeeve7Je9cXtkQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    [IsoId("_gNEyB45UEeeiH8xEoW101w")]
    [DisplayName("Home Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HomePhneNb")]
    #endif
    [IsoXmlTag("HomePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? HomePhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HomePhoneNumber { get; init; } 
    #else
    public System.String? HomePhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    [IsoId("_gNEyCI5UEeeiH8xEoW101w")]
    [DisplayName("Business Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizPhneNb")]
    #endif
    [IsoXmlTag("BizPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? BusinessPhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessPhoneNumber { get; init; } 
    #else
    public System.String? BusinessPhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    [IsoId("_gNEyCY5UEeeiH8xEoW101w")]
    [DisplayName("Mobile Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MobPhneNb")]
    #endif
    [IsoXmlTag("MobPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? MobilePhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MobilePhoneNumber { get; init; } 
    #else
    public System.String? MobilePhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    [IsoId("_gNEyCo5UEeeiH8xEoW101w")]
    [DisplayName("Other Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPhneNb")]
    #endif
    [IsoXmlTag("OthrPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? OtherPhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherPhoneNumber { get; init; } 
    #else
    public System.String? OtherPhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    [IsoId("_gNEyC45UEeeiH8xEoW101w")]
    [DisplayName("Personal Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnlEmailAdr")]
    #endif
    [IsoXmlTag("PrsnlEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? PersonalEmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PersonalEmailAddress { get; init; } 
    #else
    public System.String? PersonalEmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Business email address of contact.
    /// </summary>
    [IsoId("_gNEyDI5UEeeiH8xEoW101w")]
    [DisplayName("Business Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizEmailAdr")]
    #endif
    [IsoXmlTag("BizEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? BusinessEmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessEmailAddress { get; init; } 
    #else
    public System.String? BusinessEmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Other email address of contact.
    /// </summary>
    [IsoId("_gNEyDY5UEeeiH8xEoW101w")]
    [DisplayName("Other Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrEmailAdr")]
    #endif
    [IsoXmlTag("OthrEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? OtherEmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherEmailAddress { get; init; } 
    #else
    public System.String? OtherEmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a home FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_DkrWo1yuEeeve7Je9cXtkQ")]
    [DisplayName("Home Fax Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HomeFaxNb")]
    #endif
    [IsoXmlTag("HomeFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? HomeFaxNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HomeFaxNumber { get; init; } 
    #else
    public System.String? HomeFaxNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a home FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_wAu4AI5UEeeiH8xEoW101w")]
    [DisplayName("Business Fax Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFaxNb")]
    #endif
    [IsoXmlTag("BizFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? BusinessFaxNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessFaxNumber { get; init; } 
    #else
    public System.String? BusinessFaxNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_DkrWqVyuEeeve7Je9cXtkQ")]
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
    [IsoId("_Jvq5QFyuEeeve7Je9cXtkQ")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO2ALanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    
    #nullable disable
    
}
