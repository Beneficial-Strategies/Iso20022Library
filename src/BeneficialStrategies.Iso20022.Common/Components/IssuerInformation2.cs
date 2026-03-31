// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_YPYKEVthEeSwKe7KuKvXhg")]
[DisplayName("Issuer Information")]
public record IssuerInformation2
{
    /// <summary>
    /// Unique and unambiguous way to identify the organisation.
    /// </summary>
    [IsoId("_YrzAUVthEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification40Choice_ Identification { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_YrzAU1thEeSwKe7KuKvXhg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }
}
