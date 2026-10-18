// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the contact person.
/// </summary>
[IsoId("_q1hc0W4_EeiU9cctagi5ow")]
public interface IContact4 : IIsoComponent
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_q-wRU24_EeiU9cctagi5ow")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    NamePrefix2Code? NamePrefix { get; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_q-wRVW4_EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRV24_EeiU9cctagi5ow")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    IsoPhoneNumber? PhoneNumber { get; }

    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRWW4_EeiU9cctagi5ow")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    IsoPhoneNumber? MobileNumber { get; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_q-wRW24_EeiU9cctagi5ow")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    IsoPhoneNumber? FaxNumber { get; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_q-wRXW4_EeiU9cctagi5ow")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    IsoMax2048Text? EmailAddress { get; }

    /// <summary>
    /// Purpose for which an email address may be used.
    /// </summary>
    [IsoId("_6a6f0b18Eeiut6mmSKzDFQ")]
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    IsoMax35Text? EmailPurpose { get; }

    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_65ANYXRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    IsoMax35Text? JobTitle { get; }

    /// <summary>
    /// Role of a person in an organisation.
    /// </summary>
    [IsoId("_65ANYnRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    IsoMax35Text? Responsibility { get; }

    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_65ANY3RnEeiH1ZOt2UD8vQ")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    IsoMax70Text? Department { get; }

    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_A96WInRoEeiH1ZOt2UD8vQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IEnumerable<IOtherContact1> Other { get; }

    /// <summary>
    /// Preferred method used to reach the contact.
    /// </summary>
    [IsoId("_A96WI3RoEeiH1ZOt2UD8vQ")]
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    PreferredContactMethod1Code? PreferredMethod { get; }
}
