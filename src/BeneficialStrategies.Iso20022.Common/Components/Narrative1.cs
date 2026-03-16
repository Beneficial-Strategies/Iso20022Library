// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Narrative information for an undertaking.
/// </summary>
[IsoId("_94mSknltEeG7BsjMvd1mEw_1059061696")]
[DisplayName("Narrative")]
public record Narrative1
{
    /// <summary>
    /// Type of term or condition.
    /// </summary>
    [IsoId("_94mSk3ltEeG7BsjMvd1mEw_860460142")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public NarrativeType1Choice_? Type { get; init; }

    /// <summary>
    /// Narrative text.
    /// </summary>
    [IsoId("_94mSlHltEeG7BsjMvd1mEw_-1855880326")]
    [DisplayName("Text")]
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [MinLength(1)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = [];
}
