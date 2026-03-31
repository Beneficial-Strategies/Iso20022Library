// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a multi-leg interest derivative.
/// </summary>
[IsoId("_HzdA2X5aEea2k7EBUopqxw")]
[DisplayName("Derivative Interest")]
public record DerivativeInterest3
{
    /// <summary>
    /// Provides the interest rate in number of days, weeks, months or years.
    /// </summary>
    [IsoId("_H7ydcX5aEea2k7EBUopqxw")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public required FloatingInterestRate8 InterestRate { get; init; }

    /// <summary>
    /// Interest rate of the notional currency.
    /// </summary>
    [IsoId("_H7ydc35aEea2k7EBUopqxw")]
    [DisplayName("First Leg Interest Rate")]
    [IsoXmlTag("FrstLegIntrstRate")]
    public InterestRate8Choice_? FirstLegInterestRate { get; init; }

    /// <summary>
    /// Notional currency in which leg 2 of the contract is denominated, in case of multi-currency or cross-currency swaps.
    /// Notional currency in which leg 2 of the swap is denominated, in case of swaptions where the underlying swap is multi-currency.
    /// </summary>
    [IsoId("_H7yddX5aEea2k7EBUopqxw")]
    [DisplayName("Other Notional Currency")]
    [IsoXmlTag("OthrNtnlCcy")]
    public ActiveOrHistoricCurrencyCode? OtherNotionalCurrency { get; init; }

    /// <summary>
    /// Indication of the interest rate used for leg 2, if applicable.
    /// </summary>
    [IsoId("_H7ydd35aEea2k7EBUopqxw")]
    [DisplayName("Other Leg Interest Rate")]
    [IsoXmlTag("OthrLegIntrstRate")]
    public InterestRate8Choice_? OtherLegInterestRate { get; init; }
}
