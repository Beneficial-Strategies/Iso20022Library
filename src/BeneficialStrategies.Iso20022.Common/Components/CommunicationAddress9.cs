// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication information.
/// </summary>
[IsoId("_CwaX8dwtEeeKpa-yxjuKzQ")]
[DisplayName("Communication Address")]
public record CommunicationAddress9
{
    /// <summary>
    /// Postal address of the entity.
    /// </summary>
    [IsoId("_C6HGgdwtEeeKpa-yxjuKzQ")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress22? PostalAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_C6HGg9wtEeeKpa-yxjuKzQ")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example used over the www (HTTP) service.
    /// </summary>
    [IsoId("_C6HGhdwtEeeKpa-yxjuKzQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_C6HGh9wtEeeKpa-yxjuKzQ")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Phone { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_C6HGidwtEeeKpa-yxjuKzQ")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_C6HGi9wtEeeKpa-yxjuKzQ")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }
}
