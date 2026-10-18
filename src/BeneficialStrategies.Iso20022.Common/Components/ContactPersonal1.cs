// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact Personal1.
/// </summary>
[IsoId("_V8JsAW9qEe6DxcrvCrq6hQ")]
[DisplayName("Contact Personal1")]
public record ContactPersonal1
{
    /// <summary>
    /// Business Email.
    /// </summary>
    [DisplayName("Business Email")]
    [IsoXmlTag("BizEmail")]
    public Max256Text? BusinessEmail { get; init; }

    /// <summary>
    /// Business Fax.
    /// </summary>
    [DisplayName("Business Fax")]
    [IsoXmlTag("BizFax")]
    public PhoneNumber? BusinessFax { get; init; }

    /// <summary>
    /// Business Phone.
    /// </summary>
    [DisplayName("Business Phone")]
    [IsoXmlTag("BizPhne")]
    public PhoneNumber? BusinessPhone { get; init; }

    /// <summary>
    /// Given Name.
    /// </summary>
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public Max35Text? GivenName { get; init; }

    /// <summary>
    /// Home Fax.
    /// </summary>
    [DisplayName("Home Fax")]
    [IsoXmlTag("HomeFax")]
    public PhoneNumber? HomeFax { get; init; }

    /// <summary>
    /// Home Phone.
    /// </summary>
    [DisplayName("Home Phone")]
    [IsoXmlTag("HomePhne")]
    public PhoneNumber? HomePhone { get; init; }

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
    /// Mobile Phone.
    /// </summary>
    [DisplayName("Mobile Phone")]
    [IsoXmlTag("MobPhne")]
    public PhoneNumber? MobilePhone { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max70Text? Name { get; init; }

    /// <summary>
    /// Other Email.
    /// </summary>
    [DisplayName("Other Email")]
    [IsoXmlTag("OthrEmail")]
    public Max256Text? OtherEmail { get; init; }

    /// <summary>
    /// Other Phone.
    /// </summary>
    [DisplayName("Other Phone")]
    [IsoXmlTag("OthrPhne")]
    public PhoneNumber? OtherPhone { get; init; }

    /// <summary>
    /// Personal Email.
    /// </summary>
    [DisplayName("Personal Email")]
    [IsoXmlTag("PrsnlEmail")]
    public Max256Text? PersonalEmail { get; init; }

    /// <summary>
    /// URL.
    /// </summary>
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public Max256Text? URL { get; init; }
}
