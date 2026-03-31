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
[IsoId("_QDdht9p-Ed-ak6NoX_4Aeg_-1442959327")]
[DisplayName("Contact Identification")]
public record ContactIdentification4
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QDdhuNp-Ed-ak6NoX_4Aeg_-1381085869")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Specifies the terms used to formally address a person, eg, Ms.
    /// </summary>
    [IsoId("_QDdhudp-Ed-ak6NoX_4Aeg_-1381085784")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QDnSsNp-Ed-ak6NoX_4Aeg_-1381085868")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? GivenName { get; init; }

    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_QDnSsdp-Ed-ak6NoX_4Aeg_-1381085806")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Role { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QDnSstp-Ed-ak6NoX_4Aeg_-1381085807")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QDnSs9p-Ed-ak6NoX_4Aeg_-1381085838")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QDnStNp-Ed-ak6NoX_4Aeg_-1381085867")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }
}
