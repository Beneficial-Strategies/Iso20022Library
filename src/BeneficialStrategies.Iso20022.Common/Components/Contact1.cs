// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact person details.
/// </summary>
[IsoId("_Kd7ugEXmEeegp_DADCe7HQ")]
[DisplayName("Contact")]
public partial record Contact1
{
    #nullable enable
    
    /// <summary>
    /// Name of the contact person.
    /// </summary>
    [IsoId("_bDr_0EXmEeegp_DADCe7HQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    [IsoId("_4roBAI5TEeeiH8xEoW101w")]
    [DisplayName("Home Phone Number")]
    [IsoXmlTag("HomePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? HomePhoneNumber { get; init; } 
    
    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    [IsoId("_-u4j8I5TEeeiH8xEoW101w")]
    [DisplayName("Business Phone Number")]
    [IsoXmlTag("BizPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? BusinessPhoneNumber { get; init; } 
    
    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    [IsoId("_Gec3sI5UEeeiH8xEoW101w")]
    [DisplayName("Mobile Phone Number")]
    [IsoXmlTag("MobPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobilePhoneNumber { get; init; } 
    
    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    [IsoId("_Le550I5UEeeiH8xEoW101w")]
    [DisplayName("Other Phone Number")]
    [IsoXmlTag("OthrPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? OtherPhoneNumber { get; init; } 
    
    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    [IsoId("_Q3w04I5UEeeiH8xEoW101w")]
    [DisplayName("Personal Email Address")]
    [IsoXmlTag("PrsnlEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? PersonalEmailAddress { get; init; } 
    
    /// <summary>
    /// Business email address of contact.
    /// </summary>
    [IsoId("_W2Z9kI5UEeeiH8xEoW101w")]
    [DisplayName("Business Email Address")]
    [IsoXmlTag("BizEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? BusinessEmailAddress { get; init; } 
    
    /// <summary>
    /// Other email address of contact.
    /// </summary>
    [IsoId("_bNzboI5UEeeiH8xEoW101w")]
    [DisplayName("Other Email Address")]
    [IsoXmlTag("OthrEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? OtherEmailAddress { get; init; } 
    
    /// <summary>
    /// Language of the contact person.
    /// </summary>
    [IsoId("_lmyLIEXmEeegp_DADCe7HQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; } 
    
    
    #nullable disable
    
}
