// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions to be filled in to obtain a valid power of attorney.
/// </summary>
[IsoId("_3-_EcV6YEeSyc4g_pm5hbw")]
[DisplayName("Power Of Attorney Requirements")]
public record PowerOfAttorneyRequirements3
{
    /// <summary>
    /// Specifies whether the power of attorney needs to be validated by some authority.
    /// </summary>
    [IsoId("_4bjEpV6YEeSyc4g_pm5hbw")]
    [DisplayName("Legal Requirement")]
    [IsoXmlTag("LglRqrmnt")]
    [MinLength(0)]
    [MaxLength(4)]
    public SimpleValueList<PowerOfAttorneyLegalisation1Code> LegalRequirement { get; init; } = [];

    /// <summary>
    /// Specifies the documents needed to obtain a valid power of attorney.
    /// </summary>
    [IsoId("_4bjEp16YEeSyc4g_pm5hbw")]
    [DisplayName("Other Documentation")]
    [IsoXmlTag("OthrDcmnttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? OtherDocumentation { get; init; }

    /// <summary>
    /// Date by which the requested documents must be provided.
    /// </summary>
    [IsoId("__XN2QF6YEeSyc4g_pm5hbw")]
    [DisplayName("Document Submission Deadline")]
    [IsoXmlTag("DocSubmissnDdln")]
    public DateFormat29Choice_? DocumentSubmissionDeadline { get; init; }
}
