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
/// Information needed to contact a physical person.
/// </summary>
[IsoId("_QB-T89p-Ed-ak6NoX_4Aeg_-1034387476")]
[DisplayName("Contact Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContactIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContactIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContactIdentification2( System.String reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QB-T9Np-Ed-ak6NoX_4Aeg_-1034386173")]
    [DisplayName("Name Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmPrfx")]
    #endif
    [IsoXmlTag("NmPrfx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamePrefix1Code? NamePrefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamePrefix1Code? NamePrefix { get; init; } 
    #else
    public NamePrefix1Code? NamePrefix { get; set; } 
    #endif
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QB-T9dp-Ed-ak6NoX_4Aeg_-1034386605")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GivenName { get; init; } 
    #else
    public System.String? GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QB-T9tp-Ed-ak6NoX_4Aeg_-1034387034")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QB-T99p-Ed-ak6NoX_4Aeg_-1034386493")]
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
    [IsoId("_QB-T-Np-Ed-ak6NoX_4Aeg_700909475")]
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
    [IsoId("_QCHd4Np-Ed-ak6NoX_4Aeg_-1034386528")]
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
    [IsoId("_QCHd4dp-Ed-ak6NoX_4Aeg_-1034386570")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
