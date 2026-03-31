// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or address used for communication.
/// </summary>
[IsoId("_bqpfQboKEeq5Lv5RTGDs7Q")]
[DisplayName("Contact Attributes")]
public record ContactAttributes6
{
    /// <summary>
    /// Name of the party.
    /// </summary>
    [IsoId("_b_xas7oKEeq5Lv5RTGDs7Q")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Address of the party.
    /// </summary>
    [IsoId("_b_xatboKEeq5Lv5RTGDs7Q")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress1? PostalAddress { get; init; }

    /// <summary>
    /// Phone number of the party.
    /// </summary>
    [IsoId("_b_xat7oKEeq5Lv5RTGDs7Q")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Fax number of the party.
    /// </summary>
    [IsoId("_b_xauboKEeq5Lv5RTGDs7Q")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail) for the party.
    /// </summary>
    [IsoId("_b_xau7oKEeq5Lv5RTGDs7Q")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_b_xavboKEeq5Lv5RTGDs7Q")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; }

    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    [IsoId("_b_xav7oKEeq5Lv5RTGDs7Q")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_b_xawboKEeq5Lv5RTGDs7Q")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
