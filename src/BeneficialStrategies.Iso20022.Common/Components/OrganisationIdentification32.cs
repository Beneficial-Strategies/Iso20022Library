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
[IsoId("_vS1-Yf0mEeiVx5e_oHKxzQ")]
[DisplayName("Organisation Identification")]
public record OrganisationIdentification32
{
    /// <summary>
    /// Code allocated to an institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_v1W1kf0mEeiVx5e_oHKxzQ")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_v1W1k_0mEeiVx5e_oHKxzQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericOrganisationIdentification2? Other { get; init; }
}
