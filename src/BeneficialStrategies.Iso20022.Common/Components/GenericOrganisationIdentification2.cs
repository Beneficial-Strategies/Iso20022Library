// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
[IsoId("_8mFNgRBAEeGyZLI6olyk-Q")]
[DisplayName("Generic Organisation Identification")]
public record GenericOrganisationIdentification2
{
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_8mFNhxBAEeGyZLI6olyk-Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text Identification { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_8mFNixBAEeGyZLI6olyk-Q")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public OrganisationIdentificationSchemeName2Choice_? SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_8mFNjxBAEeGyZLI6olyk-Q")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? Issuer { get; init; }
}
