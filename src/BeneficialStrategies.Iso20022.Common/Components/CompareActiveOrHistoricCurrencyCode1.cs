// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an active or historic currency code.
/// </summary>
[IsoId("_KJLKwU0aEeyQkYR0RbXyEg")]
[DisplayName("Compare Active Or Historic Currency Code")]
public record CompareActiveOrHistoricCurrencyCode1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_KK-hk00aEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ActiveOrHistoricCurrencyCode? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_KK-hlU0aEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ActiveOrHistoricCurrencyCode? Value2 { get; init; }
}
