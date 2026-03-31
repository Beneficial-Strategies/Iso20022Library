// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount.
/// </summary>
[IsoId("_10alMTGbEeO118ZQJgaQSQ")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection41
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_2FYZYTGbEeO118ZQJgaQSQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_2FYZYzGbEeO118ZQJgaQSQ")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
