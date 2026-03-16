// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the contact person.
/// </summary>
[IsoId("_q61ikIv3Eei289CGNqs21g")]
[DisplayName("Contact")]
public record Contact5
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_rJkiI4v3Eei289CGNqs21g")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_rJkiJYv3Eei289CGNqs21g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_rJkiJ4v3Eei289CGNqs21g")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_rJkiKYv3Eei289CGNqs21g")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_rJkiK4v3Eei289CGNqs21g")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_rJkiLYv3Eei289CGNqs21g")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? EmailAddress { get; init; }

    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    [IsoId("_rJlJMYv3Eei289CGNqs21g")]
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EmailPurpose { get; init; }

    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_rJlJM4v3Eei289CGNqs21g")]
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? JobTitle { get; init; }

    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    [IsoId("_rJlJNYv3Eei289CGNqs21g")]
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Responsibility { get; init; }

    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_rJlJN4v3Eei289CGNqs21g")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_rJlJOYv3Eei289CGNqs21g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <summary>
    /// Preferred method used to reach the technical contact.
    /// </summary>
    [IsoId("_rJlJO4v3Eei289CGNqs21g")]
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod1Code? PreferredMethod { get; init; }

    /// <summary>
    /// Starting validity date for the contact.
    /// </summary>
    [IsoId("_vDRXkov3Eei289CGNqs21g")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; }

    /// <summary>
    /// Ending validity date for the contact.
    /// </summary>
    [IsoId("_vDRXk4v3Eei289CGNqs21g")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidTo { get; init; }
}
