// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
[IsoId("_QEVBobZoEfCUZfsQO4rYeA")]
[DisplayName("Currency Conversion36")]
public record CurrencyConversion36
{
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_QFQOtbZoEfCUZfsQO4rYeA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse3Code Result { get; init; }

    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_QFQOu7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    public IsoMax35Text? ResultReason { get; init; }

    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_QFQOwbZoEfCUZfsQO4rYeA")]
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public ValueList<CurrencyConversion34> ConversionDetails { get; init; } = [];
}
