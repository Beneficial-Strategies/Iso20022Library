// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of values assigned to a special programme.
/// </summary>
[IsoId("_nfCugEU8Eeea-M6VZkEPUw")]
[DisplayName("Special Programme Details")]
public record SpecialProgrammeDetails1
{
    /// <summary>
    /// Name of the special programme detail.
    /// </summary>
    [IsoId("_99USYEU8Eeea-M6VZkEPUw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Special programme detail value.
    /// </summary>
    [IsoId("_HO0S8EU9Eeea-M6VZkEPUw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Value { get; init; }
}
