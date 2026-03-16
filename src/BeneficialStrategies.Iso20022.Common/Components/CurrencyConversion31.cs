// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion31.
/// </summary>
[IsoId("__HDc0ZFFEe6reqfAp4CunQ")]
[DisplayName("Currency Conversion31")]
public record CurrencyConversion31
{
    /// <summary>
    /// Conversion Details.
    /// </summary>
    [DisplayName("Conversion Details")]
    [IsoXmlTag("ConvsDtls")]
    public ValueList<CurrencyConversion29> ConversionDetails { get; init; } = [];

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse3Code Result { get; init; }

    /// <summary>
    /// Result Reason.
    /// </summary>
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    public IsoMax35Text? ResultReason { get; init; }
}
