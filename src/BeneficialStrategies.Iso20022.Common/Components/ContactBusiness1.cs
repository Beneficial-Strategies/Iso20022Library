// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact Business1.
/// </summary>
[IsoId("_7vkj4XNaEe6Y1uOeeiF_Eg")]
[DisplayName("Contact Business1")]
public record ContactBusiness1
{
    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public Max256Text? Email { get; init; }

    /// <summary>
    /// Fax.
    /// </summary>
    [DisplayName("Fax")]
    [IsoXmlTag("Fax")]
    public PhoneNumber? Fax { get; init; }

    /// <summary>
    /// Given Name.
    /// </summary>
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public Max35Text? GivenName { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }

    /// <summary>
    /// Last Name.
    /// </summary>
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public Max35Text? LastName { get; init; }

    /// <summary>
    /// Middle Name.
    /// </summary>
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public Max35Text? MiddleName { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max70Text? Name { get; init; }

    /// <summary>
    /// Phone.
    /// </summary>
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public PhoneNumber? Phone { get; init; }

    /// <summary>
    /// Property Phone.
    /// </summary>
    [DisplayName("Property Phone")]
    [IsoXmlTag("PrprtyPhne")]
    public PhoneNumber? PropertyPhone { get; init; }

    /// <summary>
    /// Toll Free Phone.
    /// </summary>
    [DisplayName("Toll Free Phone")]
    [IsoXmlTag("TollFreePhne")]
    public PhoneNumber? TollFreePhone { get; init; }

    /// <summary>
    /// URL.
    /// </summary>
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public Max256Text? URL { get; init; }
}
