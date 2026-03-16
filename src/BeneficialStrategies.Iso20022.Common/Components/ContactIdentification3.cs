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
[IsoId("_QDTwsdp-Ed-ak6NoX_4Aeg_-1939165929")]
[DisplayName("Contact Identification")]
public record ContactIdentification3
{
    /// <summary>
    /// Business Identifier Code to identify the financial institution that the contact person belongs to.
    /// </summary>
    [IsoId("_QDTwstp-Ed-ak6NoX_4Aeg_-1827416739")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier BIC { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QDTws9p-Ed-ak6NoX_4Aeg_-1939165898")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; }

    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QDTwtNp-Ed-ak6NoX_4Aeg_-1939165414")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; }

    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QDTwtdp-Ed-ak6NoX_4Aeg_-1939165838")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_QDTwttp-Ed-ak6NoX_4Aeg_-1939165662")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Role { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QDTwt9p-Ed-ak6NoX_4Aeg_-1939165684")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QDTwuNp-Ed-ak6NoX_4Aeg_-1939165715")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QDdhsNp-Ed-ak6NoX_4Aeg_-1939165776")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }
}
