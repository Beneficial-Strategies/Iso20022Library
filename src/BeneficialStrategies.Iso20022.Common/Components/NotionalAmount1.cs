// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reference amount from which contractual payments are determined and the schedule applicable to the payments.
/// </summary>
[IsoId("_WrPhgAbKEeqrW7Meu5r3kQ")]
[DisplayName("Notional Amount")]
public record NotionalAmount1
{
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_aDpnwQbKEeqrW7Meu5r3kQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection106 Amount { get; init; }

    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in monetary amounts varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_h7Os4eXtEemUbdOm9aOvMg")]
    [DisplayName("Schedule")]
    [IsoXmlTag("Schdl")]
    public Schedule3? Schedule { get; init; }
}
