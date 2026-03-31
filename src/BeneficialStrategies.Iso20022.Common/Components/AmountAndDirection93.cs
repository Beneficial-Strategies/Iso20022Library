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
[IsoId("_zzErYdwrEeeKpa-yxjuKzQ")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection93
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_z8Fdc9wrEeeKpa-yxjuKzQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_96C7YNwrEeeKpa-yxjuKzQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_z8FdddwrEeeKpa-yxjuKzQ")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
