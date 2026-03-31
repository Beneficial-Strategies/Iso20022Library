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
[IsoId("_q1hc0W4_EeiU9cctagi5ow")]
[DisplayName("Contact")]
public record Contact4
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_q-wRU24_EeiU9cctagi5ow")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_q-wRVW4_EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRV24_EeiU9cctagi5ow")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRWW4_EeiU9cctagi5ow")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRW24_EeiU9cctagi5ow")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_q-wRXW4_EeiU9cctagi5ow")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? EmailAddress { get; init; }

    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    [IsoId("_6a6f0b18Eeiut6mmSKzDFQ")]
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EmailPurpose { get; init; }

    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_65ANYXRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? JobTitle { get; init; }

    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    [IsoId("_65ANYnRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Responsibility { get; init; }

    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_65ANY3RnEeiH1ZOt2UD8vQ")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_A96WInRoEeiH1ZOt2UD8vQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <summary>
    /// Preferred method used to reach the contact.
    /// </summary>
    [IsoId("_A96WI3RoEeiH1ZOt2UD8vQ")]
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod1Code? PreferredMethod { get; init; }
}
