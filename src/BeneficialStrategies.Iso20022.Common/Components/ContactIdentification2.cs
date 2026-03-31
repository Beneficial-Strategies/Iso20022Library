// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to contact a physical person.
/// </summary>
[IsoId("_QB-T89p-Ed-ak6NoX_4Aeg_-1034387476")]
[DisplayName("Contact Identification")]
public record ContactIdentification2
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QB-T9Np-Ed-ak6NoX_4Aeg_-1034386173")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QB-T9dp-Ed-ak6NoX_4Aeg_-1034386605")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QB-T9tp-Ed-ak6NoX_4Aeg_-1034387034")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QB-T99p-Ed-ak6NoX_4Aeg_-1034386493")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QB-T-Np-Ed-ak6NoX_4Aeg_700909475")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QCHd4Np-Ed-ak6NoX_4Aeg_-1034386528")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QCHd4dp-Ed-ak6NoX_4Aeg_-1034386570")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }
}
