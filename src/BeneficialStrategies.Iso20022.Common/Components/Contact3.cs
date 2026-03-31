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
[IsoId("_4-TwPfM4Eei4qfiLgRIZBA")]
[DisplayName("Contact")]
public record Contact3
{
    /// <summary>
    /// Central phone number for the contact.
    /// </summary>
    [IsoId("_4-UXSPM4Eei4qfiLgRIZBA")]
    [DisplayName("Central Phone Number")]
    [IsoXmlTag("CntrlPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? CentralPhoneNumber { get; init; }

    /// <summary>
    /// Property phone number for the contact.
    /// </summary>
    [IsoId("_4-TwPvM4Eei4qfiLgRIZBA")]
    [DisplayName("Property Phone Number")]
    [IsoXmlTag("PrprtyPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PropertyPhoneNumber { get; init; }

    /// <summary>
    /// Toll-free phone number for the contact.
    /// </summary>
    [IsoId("_4-UXQ_M4Eei4qfiLgRIZBA")]
    [DisplayName("Toll Free Phone Number")]
    [IsoXmlTag("TollFreePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? TollFreePhoneNumber { get; init; }

    /// <summary>
    /// Email address of contact.
    /// </summary>
    [IsoId("_4-UXSvM4Eei4qfiLgRIZBA")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Fax phone number.
    /// </summary>
    [IsoId("_4-UXRvM4Eei4qfiLgRIZBA")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_4-UXQPM4Eei4qfiLgRIZBA")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_4-UXQfM4Eei4qfiLgRIZBA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }
}
