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
[IsoId("_UAyYoS8_Eeu125Ip9zFcsQ")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion22
{
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_UNQHUS8_Eeu125Ip9zFcsQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse3Code Result { get; init; }

    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_UNQHUy8_Eeu125Ip9zFcsQ")]
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResultReason { get; init; }

    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_UNQHVS8_Eeu125Ip9zFcsQ")]
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public ValueList<CurrencyConversion20> ConversionDetails { get; init; } = [];
}
