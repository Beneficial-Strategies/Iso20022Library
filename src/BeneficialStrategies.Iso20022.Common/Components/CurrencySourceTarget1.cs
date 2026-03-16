// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_77TPRKMgEeCJ6YNENx4h-w_-284480309")]
[DisplayName("Currency Source Target")]
public record CurrencySourceTarget1
{
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_77TPRaMgEeCJ6YNENx4h-w_307194081")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_77TPRqMgEeCJ6YNENx4h-w_-288526155")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveOrHistoricCurrencyCode TargetCurrency { get; init; }
}
