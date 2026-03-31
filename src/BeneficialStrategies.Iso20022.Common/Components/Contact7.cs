// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_dwV7IVaAEeeFltjJxERUxw")]
[DisplayName("Contact")]
public record Contact7
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_d8ZaIVaAEeeFltjJxERUxw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_d8ZaI1aAEeeFltjJxERUxw")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_d8ZaJVaAEeeFltjJxERUxw")]
    [DisplayName("Telephone Number")]
    [IsoXmlTag("TelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? TelephoneNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_d8ZaJ1aAEeeFltjJxERUxw")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_mrobIFaAEeeFltjJxERUxw")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }
}
