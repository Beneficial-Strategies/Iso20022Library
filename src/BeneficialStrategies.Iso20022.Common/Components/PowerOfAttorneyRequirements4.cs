// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conditions to get power of attorney.
/// </summary>
[IsoId("_loYSf609EemDtrWpq90Ckg")]
[DisplayName("Power Of Attorney Requirements")]
public record PowerOfAttorneyRequirements4
{
    /// <summary>
    /// Authority that must validate the power of attorney.
    /// </summary>
    [IsoId("_l-Zlpa09EemDtrWpq90Ckg")]
    [DisplayName("Legal Requirement")]
    [IsoXmlTag("LglRqrmnt")]
    [MinLength(0)]
    [MaxLength(4)]
    public SimpleValueList<PowerOfAttorneyLegalisation1Code> LegalRequirement { get; init; } = [];

    /// <summary>
    /// Documents needed to obtain a valid power of attorney.
    /// </summary>
    [IsoId("_l-Zlp609EemDtrWpq90Ckg")]
    [DisplayName("Other Documentation")]
    [IsoXmlTag("OthrDcmnttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherDocumentation { get; init; }

    /// <summary>
    /// Date by which the requested documents must be provided.
    /// </summary>
    [IsoId("_l-Zlqa09EemDtrWpq90Ckg")]
    [DisplayName("Document Submission Deadline")]
    [IsoXmlTag("DocSubmissnDdln")]
    public DateFormat58Choice_? DocumentSubmissionDeadline { get; init; }
}
