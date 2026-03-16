// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to qualify for incentive or other related programmes.
/// </summary>
[IsoId("_NqO3MEU9Eeea-M6VZkEPUw")]
[DisplayName("Special Programme Qualification")]
public record SpecialProgrammeQualification1
{
    /// <summary>
    /// Name of special programme.
    /// </summary>
    [IsoId("_hm4y4EU9Eeea-M6VZkEPUw")]
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Programme { get; init; }

    /// <summary>
    /// Name and value associated with a special programme.
    /// </summary>
    [IsoId("_oRYU8EU9Eeea-M6VZkEPUw")]
    [DisplayName("Detail")]
    [IsoXmlTag("Dtl")]
    public SpecialProgrammeDetails1? Detail { get; init; }
}
