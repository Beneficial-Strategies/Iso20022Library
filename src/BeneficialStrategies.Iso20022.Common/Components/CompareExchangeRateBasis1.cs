// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a exchange rate basis.
/// </summary>
[IsoId("_yOHHYE6bEeyEpI66tm807w")]
[DisplayName("Compare Exchange Rate Basis")]
public record CompareExchangeRateBasis1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_80vH0E6bEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ExchangeRateBasis1Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("__F9jkE6bEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ExchangeRateBasis1Choice_? Value2 { get; init; }
}
