// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
[IsoId("_mY_vsQ5rEe2xs7BqO31w6w")]
[DisplayName("Amount And Currency Exchange Details")]
public record AmountAndCurrencyExchangeDetails6
{
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    [IsoId("_mjB1cw5rEe2xs7BqO31w6w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Amount of money to be exchanged against another amount of money in the counter currency.
    /// </summary>
    [IsoId("_mjB1dQ5rEe2xs7BqO31w6w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    [IsoId("_mjB1dw5rEe2xs7BqO31w6w")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange24? CurrencyExchange { get; init; }
}
