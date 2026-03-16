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
[IsoId("_QJt6wNp-Ed-ak6NoX_4Aeg_1489374809")]
[DisplayName("Contact Attributes")]
public record ContactAttributes1
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QJt6wdp-Ed-ak6NoX_4Aeg_1489374811")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QJt6wtp-Ed-ak6NoX_4Aeg_1490295913")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public required PostalAddress1 PostalAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJt6w9p-Ed-ak6NoX_4Aeg_1490294902")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public required IsoPhoneNumber PhoneNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJ3rsNp-Ed-ak6NoX_4Aeg_1490294964")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QJ3rsdp-Ed-ak6NoX_4Aeg_1490294872")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QJ3rstp-Ed-ak6NoX_4Aeg_-1675029450")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under a globally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_QJ3rs9p-Ed-ak6NoX_4Aeg_1489374870")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public IsoBICIdentifier? Identification { get; init; }
}
