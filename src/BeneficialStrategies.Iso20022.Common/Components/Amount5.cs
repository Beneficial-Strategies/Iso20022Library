// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount in a given numeric currency
/// </summary>
[IsoId("_oE8jIVJ9EeeHVODnW-1ONQ")]
[DisplayName("Amount")]
public record Amount5
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_oQjWMVJ9EeeHVODnW-1ONQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_oQjWNVJ9EeeHVODnW-1ONQ")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
