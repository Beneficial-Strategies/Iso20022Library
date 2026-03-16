// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies an organisation through client identification, a name and a domicile.
/// </summary>
[IsoId("_kcd8cZQEEeiILOjNP8ro1w")]
[DisplayName("Organisation Identification")]
public record OrganisationIdentification30
{
    /// <summary>
    /// Unique and unambiguous identification of the organisation.
    /// </summary>
    [IsoId("_kn9awZQEEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification8Choice_ Identification { get; init; }

    /// <summary>
    /// Indicates the name of the reporting counterparty.
    /// </summary>
    [IsoId("_kn9aw5QEEeiILOjNP8ro1w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// Indicates the domicile of counterparty.
    /// </summary>
    [IsoId("_kn9axZQEEeiILOjNP8ro1w")]
    [DisplayName("Domicile")]
    [IsoXmlTag("Dmcl")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? Domicile { get; init; }
}
