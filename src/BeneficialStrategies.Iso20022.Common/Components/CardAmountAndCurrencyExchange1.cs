// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the detailed or original amount and currency.
/// </summary>
[IsoId("_Y95TJ_wLEeGHDMP28rpT3g_903585548")]
[DisplayName("Card Amount And Currency Exchange")]
public record CardAmountAndCurrencyExchange1
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_Y95TKPwLEeGHDMP28rpT3g_789746482")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_Y95TKfwLEeGHDMP28rpT3g_-207325871")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange3? CurrencyExchange { get; init; }

    /// <summary>
    /// Identification or qualification of the type of amount.
    /// </summary>
    [IsoId("_Y-DEIPwLEeGHDMP28rpT3g_-1204398224")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeOfAmount3Code? Type { get; init; }
}
