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
[IsoId("_bfxG4fa2EeerBJ4shjAzSA")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion16
{
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_bv_UMfa2EeerBJ4shjAzSA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse3Code Result { get; init; }

    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_bv_UM_a2EeerBJ4shjAzSA")]
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResultReason { get; init; }

    /// <summary>
    /// Information about the conversion of currency.
    /// </summary>
    [IsoId("_bv_UNfa2EeerBJ4shjAzSA")]
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public ValueList<CurrencyConversion14> ConversionDetails { get; init; } = [];
}
