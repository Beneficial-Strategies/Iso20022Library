// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Exchange25.
/// </summary>
[IsoId("_He3X8Ot9Ee6GDu6DljhDaQ")]
[DisplayName("Currency Exchange25")]
public record CurrencyExchange25
{
    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("")]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Source Currency.
    /// </summary>
    [DisplayName("Source Currency")]
    [IsoXmlTag("")]
    public required CurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Target Currency.
    /// </summary>
    [DisplayName("Target Currency")]
    [IsoXmlTag("")]
    public required CurrencyCode TargetCurrency { get; init; }
}
