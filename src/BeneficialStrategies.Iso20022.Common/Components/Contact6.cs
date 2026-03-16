// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a contact person.
/// </summary>
[IsoId("_nFpsXfPXEeihCvvpsmGI2w")]
[DisplayName("Contact")]
public record Contact6
{
    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    [IsoId("_nFsvp_PXEeihCvvpsmGI2w")]
    [DisplayName("Home Phone Number")]
    [IsoXmlTag("HomePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? HomePhoneNumber { get; init; }

    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    [IsoId("_nFsvqPPXEeihCvvpsmGI2w")]
    [DisplayName("Business Phone Number")]
    [IsoXmlTag("BizPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? BusinessPhoneNumber { get; init; }

    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    [IsoId("_nFsvpPPXEeihCvvpsmGI2w")]
    [DisplayName("Mobile Phone Number")]
    [IsoXmlTag("MobPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobilePhoneNumber { get; init; }

    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    [IsoId("_nFsvq_PXEeihCvvpsmGI2w")]
    [DisplayName("Other Phone Number")]
    [IsoXmlTag("OthrPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? OtherPhoneNumber { get; init; }

    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    [IsoId("_nFsvo_PXEeihCvvpsmGI2w")]
    [DisplayName("Personal Email Address")]
    [IsoXmlTag("PrsnlEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? PersonalEmailAddress { get; init; }

    /// <summary>
    /// Business email address of contact.
    /// </summary>
    [IsoId("_nFsvpfPXEeihCvvpsmGI2w")]
    [DisplayName("Business Email Address")]
    [IsoXmlTag("BizEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? BusinessEmailAddress { get; init; }

    /// <summary>
    /// Other email address of contact.
    /// </summary>
    [IsoId("_nFsvpvPXEeihCvvpsmGI2w")]
    [DisplayName("Other Email Address")]
    [IsoXmlTag("OthrEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? OtherEmailAddress { get; init; }

    /// <summary>
    /// Home fax number, as defined by telecom services.
    /// </summary>
    [IsoId("_nFsvofPXEeihCvvpsmGI2w")]
    [DisplayName("Home Fax Number")]
    [IsoXmlTag("HomeFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? HomeFaxNumber { get; init; }

    /// <summary>
    /// Business fax number, as defined by telecom services.
    /// </summary>
    [IsoId("_nFsvqvPXEeihCvvpsmGI2w")]
    [DisplayName("Business Fax Number")]
    [IsoXmlTag("BizFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? BusinessFaxNumber { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_nFsvqfPXEeihCvvpsmGI2w")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_nFsvovPXEeihCvvpsmGI2w")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }
}
