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
[IsoId("_mEJhEQ5rEe2xs7BqO31w6w")]
[DisplayName("Amount And Currency Exchange Details")]
public record AmountAndCurrencyExchangeDetails5
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_mOGHQw5rEe2xs7BqO31w6w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    [IsoId("_mOGHRQ5rEe2xs7BqO31w6w")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange24? CurrencyExchange { get; init; }
}
