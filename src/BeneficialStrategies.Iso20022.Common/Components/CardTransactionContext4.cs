// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card transaction.
/// </summary>
[IsoId("_lK_YgYO8EeSWSLYdc10LRg")]
[DisplayName("Card Transaction Context")]
public record CardTransactionContext4
{
    /// <summary>
    /// Data used to assign specific condition such as liability shift or preferential interchange fees.
    /// </summary>
    [IsoId("_lXgKlYO8EeSWSLYdc10LRg")]
    [DisplayName("Special Conditions")]
    [IsoXmlTag("SpclConds")]
    public ValueList<CardTransactionCondition1> SpecialConditions { get; init; } = [];
}
