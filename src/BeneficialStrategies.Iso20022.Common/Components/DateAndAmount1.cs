// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and amount.
/// </summary>
[IsoId("_woCxwCCYEeWJd9HF2tO7BA")]
[DisplayName("Date And Amount")]
public record DateAndAmount1
{
    /// <summary>
    /// Date on which the amount is declared or registered.
    /// </summary>
    [IsoId("_9xU8MCCYEeWJd9HF2tO7BA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Amount of money.
    /// </summary>
    [IsoId("_AnbmoCCZEeWJd9HF2tO7BA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
