// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money expressed with a currency code and a debit/credit indicator.
/// </summary>
[IsoId("_qdiSsUDWEeWOL-OsSq2h6w")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection54
{
    /// <summary>
    /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
    /// </summary>
    [IsoId("_qosZ0UDWEeWOL-OsSq2h6w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd20Amount Amount { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// Usage: When absent, the amount is positive.
    /// </summary>
    [IsoId("_qosZ00DWEeWOL-OsSq2h6w")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
