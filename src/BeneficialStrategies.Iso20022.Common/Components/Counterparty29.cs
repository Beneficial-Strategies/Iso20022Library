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
[IsoId("_D79vkZQNEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
public record Counterparty29
{
    /// <summary>
    /// Unique code identifying the other counterparty of the contract.
    /// Usage:
    /// This field shall be filled from the perspective of the reporting counterparty. In case of a private individual a client code shall be used in a consistent manner.
    /// </summary>
    [IsoId("_EHY8cZQNEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification9Choice_ Identification { get; init; }

    /// <summary>
    /// Code of country where the registered office of the other counterparty is located or country of residence in case that the other counterparty is a natural person.
    /// </summary>
    [IsoId("_EHY8c5QNEeiILOjNP8ro1w")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }
}
