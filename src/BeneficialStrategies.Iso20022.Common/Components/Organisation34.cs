// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information which describes the organisation.
/// </summary>
[IsoId("_CaSPCW49EeiU9cctagi5ow")]
[DisplayName("Organisation")]
public record Organisation34
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_Cj9vc249EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FullLegalName { get; init; }

    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_Cj9vdW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification29 OrganisationIdentification { get; init; }
}
