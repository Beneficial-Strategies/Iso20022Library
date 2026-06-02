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
[IsoId("_ZWnO8Sz4EfCD0_iZ8tw-zA")]
[DisplayName("Contact Personal2")]
public record ContactPersonal2
{
    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    [IsoId("_ZY-meSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Home Phone")]
    [IsoXmlTag("HomePhne")]
    public IsoPhoneNumber? HomePhone { get; init; }

    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    [IsoId("_ZY-meyz4EfCD0_iZ8tw-zA")]
    [DisplayName("Business Phone")]
    [IsoXmlTag("BizPhne")]
    public IsoPhoneNumber? BusinessPhone { get; init; }

    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    [IsoId("_ZY-mfSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Mobile Phone")]
    [IsoXmlTag("MobPhne")]
    public IsoPhoneNumber? MobilePhone { get; init; }

    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    [IsoId("_ZY-mfyz4EfCD0_iZ8tw-zA")]
    [DisplayName("Other Phone")]
    [IsoXmlTag("OthrPhne")]
    public IsoPhoneNumber? OtherPhone { get; init; }

    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    [IsoId("_ZY-mgSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Personal Email")]
    [IsoXmlTag("PrsnlEmail")]
    public IsoMax256Text? PersonalEmail { get; init; }

    /// <summary>
    /// Business email address of contact.
    /// </summary>
    [IsoId("_ZY-mgyz4EfCD0_iZ8tw-zA")]
    [DisplayName("Business Email")]
    [IsoXmlTag("BizEmail")]
    public IsoMax256Text? BusinessEmail { get; init; }

    /// <summary>
    /// Other email address of contact.
    /// </summary>
    [IsoId("_ZY-mhSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Other Email")]
    [IsoXmlTag("OthrEmail")]
    public IsoMax256Text? OtherEmail { get; init; }

    /// <summary>
    /// Collection of information that identifies a home FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_ZY-mhyz4EfCD0_iZ8tw-zA")]
    [DisplayName("Home Fax")]
    [IsoXmlTag("HomeFax")]
    public IsoPhoneNumber? HomeFax { get; init; }

    /// <summary>
    /// Collection of information that identifies a business FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_ZY-miSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Business Fax")]
    [IsoXmlTag("BizFax")]
    public IsoPhoneNumber? BusinessFax { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_ZY-miyz4EfCD0_iZ8tw-zA")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_ZY-mjSz4EfCD0_iZ8tw-zA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }
}
