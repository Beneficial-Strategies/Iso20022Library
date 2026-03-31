// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation Identification39.
/// </summary>
[IsoId("_bKD8BTFIEe651u5xu3f5iw")]
[DisplayName("Organisation Identification39")]
public record OrganisationIdentification39
{
    /// <summary>
    /// Any BIC.
    /// </summary>
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericOrganisationIdentification3> Other { get; init; } = [];
}
