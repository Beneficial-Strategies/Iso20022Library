// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a generic type of identification requested for an organisation.
/// </summary>
[IsoId("_lvDMenFwEemaN4ndAVY1ZQ")]
[DisplayName("Generic Organisation Type")]
public record GenericOrganisationType1
{
    /// <summary>
    /// Type assigned by an institution for the organisation.
    /// </summary>
    [IsoId("_lvDMe3FwEemaN4ndAVY1ZQ")]
    [DisplayName("Requested")]
    [IsoXmlTag("Reqd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator Requested { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_lvDMfHFwEemaN4ndAVY1ZQ")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public required OrganisationIdentificationSchemeName1Choice_ SchemeName { get; init; }
}
