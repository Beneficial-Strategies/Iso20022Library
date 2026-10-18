// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOrganisationIdentification39"/>
[IsoId("_bKD8BTFIEe651u5xu3f5iw")]
[DisplayName("Organisation Identification39")]
public partial record OrganisationIdentification39
{
    /// <inheritdoc cref="IOrganisationIdentification39.AnyBIC"/>
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <inheritdoc cref="IOrganisationIdentification39.LEI"/>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <inheritdoc cref="IOrganisationIdentification39.Other"/>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericOrganisationIdentification3> Other { get; init; } = [];
}
