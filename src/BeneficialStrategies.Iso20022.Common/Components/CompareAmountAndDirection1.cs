// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an active or historic currency and amount and direction
/// </summary>
[IsoId("_KdA98cptEemrr60nKZj5JQ")]
[DisplayName("Compare Amount And Direction")]
public record CompareAmountAndDirection1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_KhyJMcptEemrr60nKZj5JQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public AmountAndDirection53? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_KhyJM8ptEemrr60nKZj5JQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public AmountAndDirection53? Value2 { get; init; }
}
