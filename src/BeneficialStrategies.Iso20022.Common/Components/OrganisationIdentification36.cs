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
[IsoId("_IEaQke9IEemVGdgB8P8uQQ")]
[DisplayName("Organisation Identification")]
public record OrganisationIdentification36
{
    /// <summary>
    /// Unique and unambiguous identification of the organisation.
    /// </summary>
    [IsoId("_IUQDYe9IEemVGdgB8P8uQQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification175 Identification { get; init; }

    /// <summary>
    /// Indicates the name of the reporting counterparty.
    /// </summary>
    [IsoId("_IUQDY-9IEemVGdgB8P8uQQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// Indicates the domicile of counterparty.
    /// </summary>
    [IsoId("_IUQDZe9IEemVGdgB8P8uQQ")]
    [DisplayName("Domicile")]
    [IsoXmlTag("Dmcl")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? Domicile { get; init; }
}
