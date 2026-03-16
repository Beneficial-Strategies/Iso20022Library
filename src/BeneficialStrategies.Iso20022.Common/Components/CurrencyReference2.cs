// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the process of a currency exchange or conversion.
/// </summary>
[IsoId("_SpYh4AEcEeCQm6a_G2yO_w_1950817465")]
[DisplayName("Currency Reference")]
public record CurrencyReference2
{
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_SpYh4QEcEeCQm6a_G2yO_w_1836978399")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyCode TargetCurrency { get; init; }

    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_SpYh4gEcEeCQm6a_G2yO_w_-1112039273")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_SpYh4wEcEeCQm6a_G2yO_w_953745112")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ValueList<ExchangeRateInformation1> ExchangeRateInformation { get; init; } = [];
}
