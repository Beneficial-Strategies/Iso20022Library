// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_Pa-eQMz3EeufhKfUxzsnrQ")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection107
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_XYj_4Mz3EeufhKfUxzsnrQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd20DecimalAmount Amount { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_ZY5f8Mz3EeufhKfUxzsnrQ")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
