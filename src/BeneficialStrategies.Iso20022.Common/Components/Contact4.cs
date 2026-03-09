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
/// Specifies the details of the contact person.
/// </summary>
[IsoId("_q1hc0W4_EeiU9cctagi5ow")]
[DisplayName("Contact")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Contact4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_q-wRU24_EeiU9cctagi5ow")]
    [DisplayName("Name Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmPrfx")]
    #endif
    [IsoXmlTag("NmPrfx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamePrefix2Code? NamePrefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamePrefix2Code? NamePrefix { get; init; } 
    #else
    public NamePrefix2Code? NamePrefix { get; set; } 
    #endif
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_q-wRVW4_EeiU9cctagi5ow")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRV24_EeiU9cctagi5ow")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhoneNumber { get; init; } 
    #else
    public System.String? PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRWW4_EeiU9cctagi5ow")]
    [DisplayName("Mobile Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MobNb")]
    #endif
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? MobileNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MobileNumber { get; init; } 
    #else
    public System.String? MobileNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRW24_EeiU9cctagi5ow")]
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
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_q-wRXW4_EeiU9cctagi5ow")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    [IsoId("_6a6f0b18Eeiut6mmSKzDFQ")]
    [DisplayName("Email Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailPurp")]
    #endif
    [IsoXmlTag("EmailPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EmailPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailPurpose { get; init; } 
    #else
    public System.String? EmailPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_65ANYXRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Job Title")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JobTitl")]
    #endif
    [IsoXmlTag("JobTitl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? JobTitle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? JobTitle { get; init; } 
    #else
    public System.String? JobTitle { get; set; } 
    #endif
    
    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    [IsoId("_65ANYnRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Responsibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspnsblty")]
    #endif
    [IsoXmlTag("Rspnsblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Responsibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Responsibility { get; init; } 
    #else
    public System.String? Responsibility { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_65ANY3RnEeiH1ZOt2UD8vQ")]
    [DisplayName("Department")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dept")]
    #endif
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Department { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Department { get; init; } 
    #else
    public System.String? Department { get; set; } 
    #endif
    
    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_A96WInRoEeiH1ZOt2UD8vQ")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherContact1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherContact1? Other { get; init; } 
    #else
    public OtherContact1? Other { get; set; } 
    #endif
    
    /// <summary>
    /// Preferred method used to reach the contact.
    /// </summary>
    [IsoId("_A96WI3RoEeiH1ZOt2UD8vQ")]
    [DisplayName("Preferred Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrefrdMtd")]
    #endif
    [IsoXmlTag("PrefrdMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreferredContactMethod1Code? PreferredMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreferredContactMethod1Code? PreferredMethod { get; init; } 
    #else
    public PreferredContactMethod1Code? PreferredMethod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
