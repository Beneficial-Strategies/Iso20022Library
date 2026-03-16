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
[IsoId("_QPrYw9p-Ed-ak6NoX_4Aeg_-869974154")]
[DisplayName("Organisation Identification")]
public record OrganisationIdentification7
{
    /// <summary>
    /// Code allocated to an institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QPrYxNp-Ed-ak6NoX_4Aeg_386164856")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? AnyBIC { get; init; }

    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_QPrYxdp-Ed-ak6NoX_4Aeg_-540824728")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericOrganisationIdentification1? Other { get; init; }
}
