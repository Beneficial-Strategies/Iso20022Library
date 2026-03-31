// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reason for the UnableToApply. It can be missing and/or incorrect information.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_VFn0C9p-Ed-ak6NoX_4Aeg_-503881610")]
[DisplayName("Missing Or Incorrect Information")]
public record MissingOrIncorrectInformation
{
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    [IsoId("_VFn0DNp-Ed-ak6NoX_4Aeg_-2094358719")]
    [DisplayName("Missing Information")]
    [IsoXmlTag("MssngInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = [];

    /// <summary>
    /// Indicates the incorrect information.
    /// </summary>
    [IsoId("_VFn0Ddp-Ed-ak6NoX_4Aeg_1320808370")]
    [DisplayName("Incorrect Information")]
    [IsoXmlTag("IncrrctInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyIncorrectInfo1Code> IncorrectInformation { get; init; } =
        [];
}
