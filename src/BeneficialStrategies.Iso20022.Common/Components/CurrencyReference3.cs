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
[IsoId("_oVtgQWoQEea5EcY2TpG1mw")]
[DisplayName("Currency Reference")]
public record CurrencyReference3
{
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_odTWAWoQEea5EcY2TpG1mw")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveCurrencyCode TargetCurrency { get; init; }

    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_odTWA2oQEea5EcY2TpG1mw")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveCurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_odTWBWoQEea5EcY2TpG1mw")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRateInformation1? ExchangeRateInformation { get; init; }
}
