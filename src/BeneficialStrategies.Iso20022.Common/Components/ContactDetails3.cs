// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_6SyVQJqlEeGSON8vddiWzQ_-774006209")]
[DisplayName("Contact Details")]
public partial record ContactDetails3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_6SyVQZqlEeGSON8vddiWzQ_556130154")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_6SyVQpqlEeGSON8vddiWzQ_-1844884135")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_6SyVQ5qlEeGSON8vddiWzQ_-766863797")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_6SyVRJqlEeGSON8vddiWzQ_1064059372")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_6SyVRZqlEeGSON8vddiWzQ_1518146641")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_6SyVRpqlEeGSON8vddiWzQ_-1736786360")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? EmailAddress { get; init; } 
    
    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_6SyVR5qlEeGSON8vddiWzQ_1486175877")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherContact1? Other { get; init; } 
    
    /// <summary>
    /// Preferred method used to reach the technical contact.
    /// </summary>
    [IsoId("_6SyVSJqlEeGSON8vddiWzQ_-128769380")]
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod1Code? PreferredMethod { get; init; } 
    
    
    #nullable disable
    
}
