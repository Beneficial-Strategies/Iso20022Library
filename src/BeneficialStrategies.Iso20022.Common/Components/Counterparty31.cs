// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_-X1pgeXDEemhPvlMxbmo_g")]
[DisplayName("Counterparty")]
public record Counterparty31
{
    /// <summary>
    /// The code of country where the registered office of the other counterparty is located or country of residence in case that the other counterparty is a natural person.
    /// </summary>
    [IsoId("_-lqDE-XDEemhPvlMxbmo_g")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Indicates if the counterparty is a legal entity or a natural person.
    /// </summary>
    [IsoId("_fSkuYO9KEemVGdgB8P8uQQ")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PartyIdentification235Choice_ IdentificationType { get; init; }
}
