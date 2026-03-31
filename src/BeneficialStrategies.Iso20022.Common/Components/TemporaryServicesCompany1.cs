// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains company related information for Temporary Services.
/// </summary>
[IsoId("_unOVWPfSEei89sMSHxl1ew")]
[DisplayName("Temporary Services Company")]
public record TemporaryServicesCompany1
{
    /// <summary>
    /// Contains the name of the individual at the contracting company that has requested temporary services.
    /// </summary>
    [IsoId("_unOVXPfSEei89sMSHxl1ew")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Contains the name of the department at the contracting company in which the temporary staff will be working.
    /// </summary>
    [IsoId("_unOVW_fSEei89sMSHxl1ew")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <summary>
    /// Identification of the temporary services company.
    /// </summary>
    [IsoId("_unOVXvfSEei89sMSHxl1ew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification197? Identification { get; init; }

    /// <summary>
    /// Contains the name of the individual at the contracting company that is supervising the temporary staff.
    /// </summary>
    [IsoId("_unOVX_fSEei89sMSHxl1ew")]
    [DisplayName("Supervisor")]
    [IsoXmlTag("Sprvsr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Supervisor { get; init; }
}
