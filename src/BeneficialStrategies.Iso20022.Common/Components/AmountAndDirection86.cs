// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash posting where the currency is implied by the context.
/// </summary>
[IsoId("_dilJ8FG0EeeqtLmveSCYmA")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection86
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_F436cFHEEeeqtLmveSCYmA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_IXnNwFHEEeeqtLmveSCYmA")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public required IsoPlusOrMinusIndicator Sign { get; init; }
}
