// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation44.
/// </summary>
[IsoId("_IKfBsTFKEe651u5xu3f5iw")]
[DisplayName("Organisation44")]
public record Organisation44
{
    /// <summary>
    /// Full Legal Name.
    /// </summary>
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    public IsoMax350Text? FullLegalName { get; init; }

    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification39 OrganisationIdentification { get; init; }
}
