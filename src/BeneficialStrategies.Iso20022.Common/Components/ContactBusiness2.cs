// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact details of a business.
/// </summary>
[IsoId("_YKYSUVN5EfC0lMwgjvMClw")]
[DisplayName("Contact Business2")]
public record ContactBusiness2
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_YM6o8VN5EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_YM6o81N5EfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_YM6o9VN5EfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_YM6o91N5EfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Main phone number for the contact.
    /// </summary>
    [IsoId("_YM6o-VN5EfC0lMwgjvMClw")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoPhoneNumber? Phone { get; init; }

    /// <summary>
    /// Property phone number for the contact.
    /// </summary>
    [IsoId("_YM6o-1N5EfC0lMwgjvMClw")]
    [DisplayName("Property Phone")]
    [IsoXmlTag("PrprtyPhne")]
    public IsoPhoneNumber? PropertyPhone { get; init; }

    /// <summary>
    /// Toll-free phone number for the contact.
    /// </summary>
    [IsoId("_YM6o_VN5EfC0lMwgjvMClw")]
    [DisplayName("Toll Free Phone")]
    [IsoXmlTag("TollFreePhne")]
    public IsoPhoneNumber? TollFreePhone { get; init; }

    /// <summary>
    /// Email address of contact.
    /// </summary>
    [IsoId("_YM6o_1N5EfC0lMwgjvMClw")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Fax phone number.
    /// </summary>
    [IsoId("_YM6pAVN5EfC0lMwgjvMClw")]
    [DisplayName("Fax")]
    [IsoXmlTag("Fax")]
    public IsoPhoneNumber? Fax { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_YM6pA1N5EfC0lMwgjvMClw")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_YM6pBVN5EfC0lMwgjvMClw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }
}
