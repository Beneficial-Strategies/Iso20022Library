// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation Identification43.
/// </summary>
[IsoId("_2nNkpAJBEe-BSY_bts84pg")]
[DisplayName("Organisation Identification43")]
public record OrganisationIdentification43
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
    public ValueList<GenericOrganisationIdentification1> Other { get; init; } = [];
}
