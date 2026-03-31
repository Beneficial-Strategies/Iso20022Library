// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data used to assign specific condition such as liability shift or preferential interchange fees.
/// </summary>
[IsoId("_02aBcHsJEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Condition")]
public record CardTransactionCondition1
{
    /// <summary>
    /// Identification of the specific condition.
    /// </summary>
    [IsoId("_DtntUHsKEeSR68OJvMfxJQ")]
    [DisplayName("Program")]
    [IsoXmlTag("Prgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Program { get; init; }

    /// <summary>
    /// Level of the condition.
    /// </summary>
    [IsoId("_H8loIHsKEeSR68OJvMfxJQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Value { get; init; }
}
