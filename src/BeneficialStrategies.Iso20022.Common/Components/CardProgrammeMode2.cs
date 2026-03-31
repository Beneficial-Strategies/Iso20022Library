// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme or brand of the card for the transaction.
/// </summary>
[IsoId("_2fS94-kOEemeDPHh-U9b6w")]
[DisplayName("Card Programme Mode")]
public record CardProgrammeMode2
{
    /// <summary>
    /// Type of card programme or brand.
    /// </summary>
    [IsoId("_2fS95ekOEemeDPHh-U9b6w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Identification of the card programme or brand.
    /// </summary>
    [IsoId("_2fS95OkOEemeDPHh-U9b6w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> Identification { get; init; } = [];
    // ID for the above is _2fS95OkOEemeDPHh-U9b6w
}
